using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.ViewModels;
namespace RoleTop_MVC.Controllers
{
    public class EspacoController : AbstractController
    {
        public IActionResult Index()
        {
            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);
        }
    }
}