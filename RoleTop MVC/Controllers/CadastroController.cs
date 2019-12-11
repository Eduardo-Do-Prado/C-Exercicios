using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Models;
using RoleTop_MVC.Repositorios;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers {
    public class CadastroController : AbstractController {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio ();
        public IActionResult Index () {
            switch(ObterUsuarioNomeSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("Index","Home");
            }
        }
        public IActionResult Login()
        {
            switch(ObterUsuarioNomeSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("Index","Home");
            }
        }

        [HttpPost]
        public IActionResult Logar(IFormCollection form)
        {
            Cliente cliente = clienteRepositorio.ObterPor(form["Usuario"]);

            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Usuario);
            return RedirectToAction("Login","Cliente");
        }
        public IActionResult CadastrarCliente (IFormCollection form) {
            try {
                Cliente cliente = new Cliente (
                    form["usuario"],
                    form["nome"],
                    form["email"],
                    form["telefone"],
                    form["cpf"],
                    DateTime.Parse (form["data-nascimento"]),
                    form["senha"]);

                clienteRepositorio.Inserir (cliente);
                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Usuario);
                    return RedirectToAction("Login","Cliente");
            } catch (Exception e) {
                return View ("Erro");
            }
        }
    }
}