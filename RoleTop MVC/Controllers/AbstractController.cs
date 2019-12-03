using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTop_MVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "SESSION_CLIENTE_EMAIL";
        protected const string SESSION_CLIENTE_NOME = "SESSION_CLIENTE_NOME";
        protected string ObterUsuarioSession()
        {
            var e = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if (!string.IsNullOrEmpty(e))
            {
                return e;
            }
            else
            {
                return "";
            }
        }
        protected string ObterUsuarioNomeSession()
        {
            var n = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if (!string.IsNullOrEmpty(n))
            {
                return n;
            }
            else
            {
                return "";
            }
        }
    }
}