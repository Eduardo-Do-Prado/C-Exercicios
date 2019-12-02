using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using McBonalds_MVC.Models;
using McBonalds_MVC.ViewModels;

namespace McBonalds_MVC.Controllers
{
    public class HomeController : AbstractController // Controller é responsavel por receber as informações e retornar o caminho correto, de acordo com o que o usuário solicitou 
    {
        public IActionResult Index()
        {
            
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioTipoSession()
            });
        }
    }
}