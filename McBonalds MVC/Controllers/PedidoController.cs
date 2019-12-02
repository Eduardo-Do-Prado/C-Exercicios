using System;
using McBonalds_MVC.Controllers;
using McBonalds_MVC.Enums;
using McBonalds_MVC.Models;
using McBonalds_MVC.Repositories;
using McBonalds_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository ();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index () {

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres = hamburguerRepository.ObterTodos();
            pedido.Shakes = shakeRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioTipoSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
            pedido.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                pedido.Cliente = clienteLogado;
            }
            pedido.NomeView = "Pedido";
            pedido.UsuarioEmail = ObterUsuarioTipoSession();
            pedido.UsuarioNome = ObterUsuarioNomeSession();

            return View (pedido);
        }

        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido ();

            Shake shake = new Shake ();
            var nomeShake = form["shake"];
            shake.Nome = nomeShake;
            shake.Preco = shakeRepository.ObterPrecoDe(form["shake"]);

            pedido.Shake = shake;

            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer (nomeHamburguer, hamburguerRepository.ObterPrecoDe(form["hamburguer"]));

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente () {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if (pedidoRepository.Inserir (pedido)) {
                return View ("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioTipoSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            } else {
                return View ("Erro", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioTipoSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Aprovar(ulong id)
        {
            Pedido pedido = pedidoRepository.ObterPor (id); 
            pedido.Status = (uint) StatusPedido.APROVADO;

            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction ("Dashboard", "Administrador");
            }
            else
            {
                return View ("Erro", new RespostaViewModel()
                {
                    Mensagem = "Houve um erro ao aprovar o pedido",
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioTipoSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Reprovar(ulong id)
        {
            Pedido pedido = pedidoRepository.ObterPor(id); 
            pedido.Status = (uint) StatusPedido.REPROVADO;

            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction ("Dashboard", "Administrador");
            }
            else
            {
                return View ("Erro", new RespostaViewModel()
                {
                    Mensagem = "Houve um erro ao Reprovar o pedido",
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioTipoSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}