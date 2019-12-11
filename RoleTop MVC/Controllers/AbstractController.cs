using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTop_MVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "CLIENTE_EMAIL";
        protected const string SESSION_CLIENTE_NOME = "CLIENTE_NOME";
        protected const string SESSION_CLIENTE_TIPO = "CLIENTE_TIPO";
        protected string ObterUsuarioSession()
        {
            var email = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if (!string.IsNullOrEmpty(email))
            {
                return email;
            }
            else
            {
                return "";
            }
        }
        protected string ObterUsuarioNomeSession()
        {
            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if (!string.IsNullOrEmpty(nome))
            {
                return nome;
            }
            else
            {
                return "";
            }
        }
        protected string ObterUsuarioTipoSession()
        {
            var tipoUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                return tipoUsuario;
            } 
            else
            {
                return "";
            }
        }

    }
}