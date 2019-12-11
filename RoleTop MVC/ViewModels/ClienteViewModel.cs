using System.Collections.Generic;
using RoleTop_MVC.Models;
namespace RoleTop_MVC.ViewModels {
    public class ClienteViewModel : BaseViewModel 
    {
        public string Usuario { get; set; }
        public List<Orcamento> Eventos { get; set; }

        public ClienteViewModel (string usuario) 
        {
            this.Eventos = new List<Orcamento> ();
            this.Usuario = usuario;
        }
    }
}