using System;
using Microsoft.Extensions.Primitives;
using RoleTop_MVC.Models;
using RoleTop_MVC.Enums;

namespace RoleTop_MVC.Models {
    public class Orcamento {
        
        public ulong ID {get;set;}
        public Cliente Cliente {get; set;}
        public DateTime DataEvento { get; set; }
        public string Evento { get; set; }
        public double QuantidadePessoas { get; set; }
        public string Observacao { get; set; }
        public Som Som { get; set; }
        public Iluminacao Iluminacao { get; set; }

        public uint Status {get;set;}

        public Orcamento (DateTime dataEvento, string evento, double quantidadePessoas, string observacao) 
        {
            this.ID = 0;
            this.Cliente = new Cliente();
            this.Iluminacao = new Iluminacao();
            this.Som = new Som();
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