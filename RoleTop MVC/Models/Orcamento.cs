using System;
using Microsoft.Extensions.Primitives;
namespace RoleTop_MVC.Models {
    public class Orcamento {
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Telefone {get;set;}
        public string CPF {get;set;} 
        public DateTime DataEvento { get; set; }
        public string Evento { get; set; }
        public double QuantidadePessoas { get; set; }
        public string Observacao { get; set; }
        public double ValorTotal { get; set; }

        public Orcamento (string nome, string email, string telefone, string cpf, DateTime dataEvento, string evento, double quantidadePessoas, string observacao) {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.DataEvento = dataEvento;
            this.Evento = evento;
            this.QuantidadePessoas = quantidadePessoas;
            this.Observacao = observacao;
        }
    }
}