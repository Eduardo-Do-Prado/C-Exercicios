using System;
using ByteBank2.Model;

namespace ByteBank2 {
    class Program {
        static void Main (string[] args) {
            string cliente1 = "Alexandre";
            string cliente2 = "César";

            #region Testa Conta Corrente
            ContaCorrente contacorrente1 = new ContaCorrente (1, 1, cliente1);
            ContaEspecial contacorrente2 = new ContaEspecial (1, 2, cliente2);
            DepositarConta(contacorrente1);
            DepositarConta(contacorrente2);
            //SacarConta(contacorrente1);
            //SacarConta(contacorrente2);
            //TransferirEntreContas(contacorrente1, contacorrente2);

            ContaEspecial contaespecial1 = new ContaEspecial (1, 1, cliente1);
            contaespecial1.setLimite(100);
            ContaEspecial contaespecial2 = new ContaEspecial (1, 2, cliente2);
            contaespecial2.setLimite(500);

            #endregion 
        }

        #region  Depositos em conta.
        public static void DepositarConta (ContaBancaria contaBancaria) {
            System.Console.WriteLine ("ByteBank - Depósito");
            System.Console.WriteLine ("--------------------------");
            System.Console.WriteLine ();
            string usuario = contaBancaria.Titular;
            System.Console.WriteLine ($"Conta:{contaBancaria.GetType()}");
            Console.WriteLine ($"Bem-vindo - {usuario}");
            Console.WriteLine ($"Agência: {contaBancaria.Agencia}   Conta: {contaBancaria}");
            Console.WriteLine ($"Saldo: {contaBancaria.Saldo}");

            #endregion
        }
    }
}