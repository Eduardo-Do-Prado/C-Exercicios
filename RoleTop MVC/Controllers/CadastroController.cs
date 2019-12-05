using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Models;
using RoleTop_MVC.Repositorio;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers {
    public class CadastroController : Controller {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio ();
        public IActionResult Index ()
        {
            return View  (new BaseViewModel() 
            {
                NomeView = "Cadastro",
                /*UsuarioEmail = ObterUsuarioSession (),
                UsuarioNome = ObterUsuarioNomeSession ()*/
            });
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["Action"] = "Cadastro";
            try {
                Cliente cliente = new Cliente
                (form["nome"], 
                form["email"], 
                form["telefone"], 
                form["cpf"], 
                DateTime.Parse (form["data-nascimento"]), 
                form["senha"]);

                clienteRepositorio.Inserir (cliente);
                return View ("Sucesso"/* , new RespostaViewModel () {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()
                }*/);
            } 
            catch (Exception e) 
            {
                System.Console.WriteLine(e.StackTrace);
                return View (/*"Erro", new RespostaViewModel () {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()
                }*/);
            }
        }
    }
}