using Microsoft.AspNetCore.Mvc;
namespace RoleTop_MVC.Controllers
{
    public class OrcamentoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Orcamento";
            return View();
        }
    }
}