using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Models;
namespace RoleTop_MVC.Controllers {
    public class OrcamentoController : Controller {
        public IActionResult Index () {
            ViewData["NomeView"] = "Orcamento";
            return View ();
        }
        public IActionResult Registrar (IFormCollection form) {
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
        }
    }
}