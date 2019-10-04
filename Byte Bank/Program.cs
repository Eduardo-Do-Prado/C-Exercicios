using System;
using Banco;

namespace ContaCorrente {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("----------------------------------------------");
            System.Console.WriteLine ("      Seja bem-vindo(a) á Byte Bank");
            System.Console.WriteLine ("----------------------------------------------");

            System.Console.WriteLine ();
            System.Console.WriteLine ("Pressione qualquer botão para posseguir");
            Console.ReadLine ();
            Console.Clear ();

            System.Console.WriteLine ($"Digite seu CPF: ");
            string Cpf = Console.ReadLine ();

            System.Console.WriteLine ($"Digite seu Nome: ");
            string Nome = Console.ReadLine ();

            System.Console.WriteLine ($"Digite seu Email: ");
            string Email = Console.ReadLine ();

            

            System.Console.WriteLine ("----------------------------------------------");
            System.Console.WriteLine ("           Seja bem-vindo(a) " + Nome);
            System.Console.WriteLine ("----------------------------------------------");

            System.Console.WriteLine ();
            System.Console.WriteLine ("Pressione qualquer botão para posseguir");
            Console.ReadLine ();
            Console.Clear ();

            System.Console.WriteLine ("Digite sua agência: ");
            int Agencia = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite sua conta: ");
            int Conta = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite seu titular: ");
            string Titular = Console.ReadLine ();

            bool saldovalido = false;
            do {
                System.Console.WriteLine ("Digite o saldo: ");
                double saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    saldovalido = true;
                } else {
                    System.Console.WriteLine ("O saldo não pode ser negativo");
                }
            }
            while (!saldovalido);

            int OpcaoBanco;

            Console.WriteLine ("Qual operação desejas realizar?");
            Console.WriteLine ("(1) Depósito | (2) Saque | (3) Transferência ");
            OpcaoBanco = int.Parse (Console.ReadLine ());

            switch (OpcaoBanco) {
                case 1:
                    
                    bool DepositoValido = false;
                    do {
                        System.Console.WriteLine ("Digite o valor do seu depósito: ");
                        double deposito = double.Parse (Console.ReadLine ());
                        if (deposito >= 0) {

                            DepositoValido = true;
                            Console.WriteLine ("Sua operação foi realizada com sucesso");
                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Seu saldo atual é de: ");

                        } else {
                            System.Console.WriteLine ("O depósito não pode ser negativo");
                        }
                    }
                    while (!DepositoValido);
                    break;

                case 2:
                    bool SaqueValido = false;
                    do {
                        System.Console.WriteLine ("Digite o valor do seu saque: ");
                        double saque = double.Parse (Console.ReadLine ());
                        if (saque >= 0) {
                            SaqueValido = true;
                            Console.WriteLine ("Sua operação foi realizada com sucesso");
                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Seu saldo atual é de: " );

                        } else {
                            System.Console.WriteLine ("O Saque não pode ser negativo");
                        }
                    }
                    while (!SaqueValido);
                    break;

                case 3:

                    bool TransferenciaValida = false;
                    do {
                        System.Console.WriteLine ("Digite o valor da sua transferência: ");
                        double transferencia = double.Parse (Console.ReadLine ());
                        if (transferencia >= 0) {
                            TransferenciaValida = true;
                            Console.WriteLine ("Sua operação foi realizada com sucesso");
                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Seu saldo atual é de: ");

                        } else {
                            System.Console.WriteLine ("A transferência não pode ser negativa");
                        }
                    }
                    while (!TransferenciaValida);
                    break;
                default:
                    Console.WriteLine ("Operação inválida");
                    break;
            }

        }
    }
}