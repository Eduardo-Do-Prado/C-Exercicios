using System.Collections.Generic;
using RoleTop_MVC.Models;
namespace RoleTop_MVC.ViewModels {
    public class ClienteViewModel : BaseViewModel 
    {
        public List<Iluminacao> Iluminacoes {get; set;}
        public List<Som> Sons {get; set;}
        public string NomeUsuario {get; set;}
        public string Usuario {get; set;}
        public Cliente Cliente {get; set;}
        public List<Orcamento> Eventos { get; set; }

        public ClienteViewModel (string usuario) 
        {
            this.Eventos = new List<Orcamento> ();
            this.Usuario = usuario;
            this.Iluminacoes = new List<Iluminacao>();
            this.Sons = new List<Som>();
            this.Cliente = new Cliente();
            this.Eventos = new List<Orcamento> ();
        }
    }
}