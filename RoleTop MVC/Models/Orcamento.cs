using System;
using Microsoft.Extensions.Primitives;
using RoleTop_MVC.Enums;

namespace RoleTop_MVC.Models {
    public class Orcamento {
        
        public ulong ID {get;set;}
        public string Organizador { get; set; }
        public DateTime DataEvento { get; set; }
        public string Evento { get; set; }
        public double QuantidadePessoas { get; set; }
        public string Observacao { get; set; }
        public uint Status {get;set;}

        public Orcamento (string organizador, DateTime dataEvento, string evento, double quantidadePessoas, string observacao) 
        {
            this.ID = 0;
            this.Organizador = "";
            this.DataEvento = dataEvento;
            this.Evento = evento;
            this.QuantidadePessoas = quantidadePessoas;
            this.Observacao = observacao;
            this.Status = (uint) StatusPedidos.PENDENTE;
        }

        public Orcamento()
        {
        }
    }
}