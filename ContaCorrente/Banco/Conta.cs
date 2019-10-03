using System;
namespace Banco
{
    public class Conta
    {
        public string Titular ;
        public int Agencia ;
        public int Numero ;
        public double Saldo ;
        public Conta (int Agencia, int Numero, string Titular){
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Titular = Titular;
        this.Saldo = 0.0;
        }
    }
}