using McBonalds_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {  
            return View();
        }
        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();

            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;
            Hamburger hamburger = new Hamburger();
            hamburger.Nome = form["Hamburguer"];
            hamburger.Preco = 0.0;
            return View ("Sucesso");
        }
    }
}