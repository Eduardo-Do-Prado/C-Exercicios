using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Repositorio;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers {
    public class ClienteController : Controller {

        /* private ClienteRepositorio clienteRepositorio = new ClienteRepositorio ();*/

        [HttpGet]
        public IActionResult Login () {
            return View ( new BaseViewModel () {
                NomeView = "Login",
                    /* UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()*/
            });
        }

        [HttpPost]
        public IActionResult Logar (IFormCollection form) {
            ViewData["Action"] = "Login";
            try {
                System.Console.WriteLine ("==========================");
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);
                System.Console.WriteLine ("==========================");

                /* var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepositorio.ObterPor (usuario);
                if (cliente != null) {
                    if (cliente.Senha.Equals (senha)) {
                        HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario); //SetString guarda uma string e armazena  na session email
                        HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                        return RedirectToAction ("Historico", "Cliente");
                    } else {
                        return View ("Erro", new RespostaViewModel ("Senha incorreta"));
                    }
                } else {
                    return View ("Erro", new RespostaViewModel ($"Usuário {usuario} não encontrado"));
                }*/

                return View("Sucesso");

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }
        }
    }
}