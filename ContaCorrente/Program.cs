using System;
using Banco;

namespace ContaCorrente {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("----------------------------------------------");
            System.Console.WriteLine ("      Seja bem-vindo(a) á Conta corrente");
            System.Console.WriteLine ("----------------------------------------------");

            System.Console.WriteLine ();
            System.Console.WriteLine ("Pressione qualquer botão para posseguir");
            Console.ReadLine ();
            Console.Clear ();

            System.Console.WriteLine ("Cadastro de conta corrente: ");
            System.Console.WriteLine ();

            System.Console.WriteLine ("Digite sua agência: ");
            int Agencia = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite sua conta: ");
            int Numero = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite seu titular: ");
            string Titular = Console.ReadLine ();

            bool saldoInvalido = true;
            do {
                System.Console.Write ("Digite o saldo: ");
                double saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0){
                    saldoInvalido = false;
                }
                else{
                    System.Console.WriteLine("O saldo não pode negativo");
                }
            }
            while (!saldoInvalido);
        }
    }
}