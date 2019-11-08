using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}