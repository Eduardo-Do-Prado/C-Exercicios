using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Models;
using RoleTop_MVC.Repositorios;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers {
    public class ClienteController : AbstractController {
        ClienteRepositorio clienterepositorio = new ClienteRepositorio ();
        
        public IActionResult Login()
        {
            switch(ObterUsuarioSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioSession());
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("Index","Home");
            }
        }
        [HttpPost]
        public IActionResult Logar(IFormCollection form)
        {
            Cliente cliente = clienterepositorio.ObterPor(form["email"]);

            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Email);
            return RedirectToAction("Index","Home");
        }
        public IActionResult Logoff () {
            HttpContext.Session.Remove (SESSION_CLIENTE_NOME);
            return RedirectToAction ("Index", "Home");
        }
    }
}