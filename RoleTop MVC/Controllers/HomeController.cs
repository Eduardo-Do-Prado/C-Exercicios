using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTop_MVC.Models;
using RoleTop_MVC.ViewModels;

namespace RoleTop_MVC.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
