using System;
using McBonalds_MVC.Enums;
using McBonalds_MVC.Repositories;
using McBonalds_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers 
{
    public class ClienteController : AbstractController 
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();

        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioTipoSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"]="Login";
            try
            {
            System.Console.WriteLine("==========================");
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["senha"]);
            System.Console.WriteLine("==========================");

            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = clienteRepository.ObterPor(usuario);

            if (cliente != null)
            {
                if(cliente.Senha.Equals(senha))
                {
                    switch(cliente.TipoUsuario){
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());
                                return RedirectToAction("Historico", "Cliente");

                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());
                                return RedirectToAction("Dashboard", "Administrador");
                        }
                    }
                else
                {
                    return View("Erro", new RespostaViewModel("Senha incorreta"));
                }
            }
            else
            {
                return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));                
            }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
            
        }
    
        public IActionResult Historico()
        {
            var emailCliente = ObterUsuarioSession();
            var pedidos = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Pedidos = pedidos,
                NomeView = "Historico",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");

        }
    }
}