using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Models;
using RoleTop_MVC.Repositorios;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers {
    public class OrcamentoController : AbstractController {
        OrcamentoRepositorio orcamentoRepositorio = new OrcamentoRepositorio ();
        IluminacaoRepositorio iluminacaoRepositorio = new IluminacaoRepositorio ();
        SomRepositorio somRepositorio = new SomRepositorio ();
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio ();
        
        public IActionResult Index () {
            var iluminacoes = iluminacaoRepositorio.ObterTodos();
            var sons = somRepositorio.ObterTodos();

            OrcamentoViewModel orcamento = new OrcamentoViewModel();
            orcamento.Iluminacoes = iluminacoes;
            orcamento.Sons = sons;

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado)){
                orcamento.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepositorio.ObterPor(usuarioLogado);
            if(clienteLogado != null){
                orcamento.Cliente = clienteLogado;
            }
            ClienteViewModel orcamentoViewModel = new ClienteViewModel  (ObterUsuarioNomeSession());
            return View(orcamentoViewModel);
        }
        public IActionResult CriarEvento () 
        {
            switch (ObterUsuarioNomeSession ()) {
                case "Administrador":
                    return RedirectToAction ("Dashboard", "Administrador");
                case "":
                    return RedirectToAction ("Index", "Home");
                default:
            ClienteViewModel orcamentoViewModel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(orcamentoViewModel);
            }
        }

        [HttpPost]
        public IActionResult CriarEvento(IFormCollection form)
        {
            try
            {
                Orcamento evento = new Orcamento(
                    DateTime.Parse(form["dataEvento"]),
                    form["evento"],
                    int.Parse(form["quantidadePessoas"]),
                    form["observacao"]
                );
                Cliente cliente = new Cliente(
                    form["usuario"]
                );
                cliente.Usuario = ObterUsuarioNomeSession();
                orcamentoRepositorio.Inserir(evento);
                
                return RedirectToAction("Index","Cliente");
                

            }catch(Exception e)
            {
                return View("Deu Ruim");
            }
        }
    }
}