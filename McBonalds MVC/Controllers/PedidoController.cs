using System;
using McBonalds_MVC.Models;
using McBonalds_MVC.Repositories;
using McBonalds_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers {
    public class PedidoController : AbstractController {

        PedidoRepository pedidoRepository = new PedidoRepository ();
        HamburguerRepository hamburguerRepository = new HamburguerRepository ();
        ShakeRepository shakeRepository = new ShakeRepository ();
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index () {
            PedidoViewModel pvm = new PedidoViewModel ();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos ();
            pvm.Shakes = shakeRepository.ObterTodos ();

            var usuariologado = ObterUsuarioSession ();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.NomeUsuario = nomeUsuarioLogado;
            }
            var clientelogado = clienteRepository.ObterPor(usuariologado);
            if (clientelogado != null)
            {
                pvm.Cliente = clientelogado; 
            }

            return View (pvm);
        }
        public IActionResult Registrar (IFormCollection form) {
            Pedido pedido = new Pedido ();

            Shake shake = new Shake ();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;

            pedido.Shake = shake;

            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer (nomeHamburguer, hamburguerRepository.ObterPrecoDe (nomeHamburguer));

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente () {
                Nome = form["Nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            pedidoRepository.Inserir (pedido);

            return View ("Sucesso");
        }
    }
}