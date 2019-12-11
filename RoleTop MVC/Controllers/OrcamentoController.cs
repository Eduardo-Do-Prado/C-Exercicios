using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Models;
using RoleTop_MVC.Repositorios;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers {
    public class OrcamentoController : AbstractController {
        OrcamentoRepositorio orcamentorepositorio = new OrcamentoRepositorio ();
        public IActionResult Index () {
            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);
        }
        /*public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Orcamento";
            try {
                Orcamento orcamento = new Orcamento (
                    form["nome"],
                    form["email"],
                    form["telefone"],
                    form["cpf"],
                    DateTime.Parse (form["data_evento"]),
                    form["evento"],
                    double.Parse (form["quantidade_pessoas"]),
                    form["observacao"]);

                return View ("Sucesso");
            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }
        }*/
        public IActionResult CriarEvento () 
        {
            switch (ObterUsuarioNomeSession ()) {
                case "Administrador":
                    return RedirectToAction ("Dashboard", "Administrador");
                case "":
                    return RedirectToAction ("Index", "Home");
                default:
                    ClienteViewModel clienteviewmodel = new ClienteViewModel (ObterUsuarioNomeSession ());
                    return View (clienteviewmodel);
            }
        }

        [HttpPost]
        public IActionResult CriarEvento(IFormCollection form)
        {
            try
            {
                Orcamento evento = new Orcamento(
                    form["Organizador"],
                    DateTime.Parse(form["DataEvento"]),
                    form["Evento"],
                    int.Parse(form["QuantidadePessoas"]),
                    form["Observacao"]
                );
                evento.Organizador = ObterUsuarioNomeSession();
                orcamentorepositorio.Inserir(evento);
                
                return RedirectToAction("Index","Cliente");
                

            }catch(Exception e)
            {
                return View("Deu Ruim");
            }
        }
    }
}