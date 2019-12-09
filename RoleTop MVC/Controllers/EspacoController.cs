using Microsoft.AspNetCore.Mvc;
namespace RoleTop_MVC.Controllers
{
    public class EspacoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Espaco";
            return View();
        }
    }
}