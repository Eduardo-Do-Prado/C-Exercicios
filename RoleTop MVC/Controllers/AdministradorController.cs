using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Repositorios;
using RoleTop_MVC.ViewModels;
namespace RoleTop_MVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        OrcamentoRepositorio orcamentorepositorio = new OrcamentoRepositorio();
        
        public IActionResult Dashboard()
        {
            switch(ObterUsuarioNomeSession())
            {
                case "vdrvgfed@vrdbvd":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioSession());
                    clienteviewmodel.Eventos = orcamentorepositorio.ObterTodosEventosPendentes();
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("Dashboard","Administrador");
            }

        }
        
        [HttpPost]
        public IActionResult Aprovar(IFormCollection form)
        {
            orcamentorepositorio.Aprovar( form["ID"] );
            return RedirectToAction("Dashboard","Administrador");
        }

        [HttpPost]
        public IActionResult Cancelar(IFormCollection form)
        {
            orcamentorepositorio.Cancelar( form["ID"] );
            return RedirectToAction("Dashboard","Administrador");
        }
    }
}