using Microsoft.AspNetCore.Mvc;
namespace RoleTop_MVC.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Feedback";
            return View();
        }
    }
}