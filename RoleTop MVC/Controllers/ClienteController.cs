using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Repositorios;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers {
    public class ClienteController : AbstractController {
        OrcamentoRepositorio orcamentorepositorio = new OrcamentoRepositorio ();
        public IActionResult Login () {
            switch (ObterUsuarioNomeSession ()) {
                case "Administrador":
                    return RedirectToAction ("Dashboard", "Administrador");
                case "":
                    return RedirectToAction ("Index", "Home");
                default:
                    ClienteViewModel clienteviewmodel = new ClienteViewModel (ObterUsuarioNomeSession ());
                    clienteviewmodel.Eventos = orcamentorepositorio.ObterEventosCliente (ObterUsuarioNomeSession ());
                    return View (clienteviewmodel);
            }
        }
        public IActionResult Logoff () {
            HttpContext.Session.Remove (SESSION_CLIENTE_NOME);
            return RedirectToAction ("Index", "Home");
        }
    }
}