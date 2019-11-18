using System;
using McBonalds_MVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers {
    public class ClienteController : Controller {

        public ClienteRepository clienteRepository = new ClienteRepository();
        [HttpPost]
        public IActionResult Login() 
        {
            return View ();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form) {
            ViewData["Action"] = "Login";
            try 
            {
                System.Console.WriteLine ("===================");
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);

                var usuario = form["email"];
                var senha = form["senha"];

                clienteRepository.ObterPor(usuario);

                return View("Sucesso");
            } 
            catch (Exception e) 
            {
                System.Console.WriteLine (e.StackTrace);
                return View("Se fodeu neguin");
            }

        }
    }
}