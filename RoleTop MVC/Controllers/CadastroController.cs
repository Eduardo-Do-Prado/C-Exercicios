using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Models;
using RoleTop_MVC.Repositorio;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers {
    public class CadastroController : Controller {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio ();
        public IActionResult Index () {
            return View();
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["Action"] = "Cadastro";
            try {
                Cliente cliente = new Cliente (
                    form["nome"],
                    form["email"],
                    form["telefone"],
                    form["cpf"],
                    DateTime.Parse (form["data-nascimento"]),
                    form["senha"]);

                clienteRepositorio.Inserir (cliente);
                return View ("Sucesso");
            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }
        }
    }
}