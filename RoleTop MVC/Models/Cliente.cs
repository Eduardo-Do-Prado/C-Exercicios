using System;

namespace RoleTop_MVC.Models
{
    public class Cliente
    {
        public string Usuario {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Telefone {get;set;}
        public string CPF {get;set;} 
        public DateTime DataNascimento {get;set;}
        public string Senha {get;set;}
        public uint TipoUsuario {get; set;}
        public Cliente ()
        {

        }
        public Cliente (string nome, string usuario, string email, string telefone, string cpf, DateTime dataNascimento, string senha)
        {
            this.Usuario = usuario;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.DataNascimento = dataNascimento;   
            this.Senha = senha;
        }
    }
}