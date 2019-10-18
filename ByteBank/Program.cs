using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("============================================");
            Console.WriteLine ("    Seja Bem-Vindo(a) á ByteBank ");
            Console.WriteLine ("============================================");

            Console.Write ("Digite seu Nome: ");
            string Nome = Console.ReadLine ();
            Console.Write ("Digite seu Cpf: ");
            string Cpf = Console.ReadLine ();
            Console.Write ("Digite seu Email: ");
            string Email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (Nome, Cpf, Email);

            bool TrocouSenha = false;
            do {
                Console.Write ("Digite a sua Senha: ");
                string Senha = Console.ReadLine ();
                TrocouSenha = cliente1.TrocaSenha (Senha);
                if (!TrocouSenha) {
                    Console.WriteLine ("Senha não atende aos requisitos");
                } else {
                    Console.WriteLine ("Senha Trocada com sucesso");
                }
            } while (!TrocouSenha);

            System.Console.WriteLine ();
            System.Console.WriteLine ("Pressione ENTER para continuar");
            Console.ReadLine ();
            Console.Clear ();

            Console.WriteLine ("Cadastro de Conta Corrente");
            Console.WriteLine ();
            Console.Write ("Agencia: ");
            int agencia = int.Parse (Console.ReadLine ());
            Console.Write ("Conta: ");
            int conta = int.Parse (Console.ReadLine ());

            bool saldoValido = false;
            double saldo;
            do {
                Console.Write ("Digite o seu Saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    saldoValido = true;
                } else {
                    Console.WriteLine ("O saldo não pode ser negativo");
                }
            } while (!saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente (agencia, conta, cliente1);
            contaCorrente.Deposito (saldo);
            contaCorrente.Agencia = 123;
            System.Console.WriteLine ();
            System.Console.WriteLine ("Pressione ENTER para continuar");
            Console.ReadLine ();
            Console.Clear ();

            Console.WriteLine ("ByteBank - Depósito");
            Cliente usuario = contaCorrente.Titular;
            Console.WriteLine ($"Bem-vindo - {usuario.Nome}");
            Console.WriteLine ($"Agência: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine ($"Saldo: {contaCorrente.Saldo}");

            bool depositoValido = false;
            double deposito;
            do {
                Console.Write ("Digite o valor do Depósito: ");
                double valor = double.Parse (Console.ReadLine ());
                deposito = contaCorrente.Deposito (valor);
                if (deposito >= 0) {
                    Console.WriteLine ($"Saldo atual: {saldo}");
                    System.Console.WriteLine ();
                    System.Console.WriteLine ("Pressione ENTER para continuar");
                    Console.ReadLine ();
                    Console.Clear ();
                } else {
                    Console.WriteLine ("O saldo não pode ser negativo");
                }
            } while (!depositoValido);

            Console.WriteLine ("ByteBank - Saque");
            Console.WriteLine ($"Bem-vindo - {usuario.Nome}");
            Console.WriteLine ($"Agência: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine ($"Saldo: {contaCorrente.Saldo}");

            bool saqueValido = false;
            double saque;
            do {
                Console.Write ("Qual o valor do Saque? ");
                Console.WriteLine ("ByteBank - Saque");
                Console.WriteLine ($"Bem vindo - {usuario.Nome}");
                Console.WriteLine ($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
                Console.WriteLine ($"Saldo: {contaCorrente.Saldo}");
                Console.Write ("Qual o valor do Saque? ");
                valor = double.Parse (Console.ReadLine ());
                if (contaCorrente.Saque (valor)) {
                    Console.WriteLine ("Saque realizado com sucesso. Retire as notas");
                } else {
                    Console.WriteLine ("Não foi possivel realizar a operação");

                }
                Console.WriteLine ($"Saldo atual: {contaCorrente.Saldo}");
                Console.WriteLine ();
                System.Console.WriteLine ();
                System.Console.WriteLine ("Pressione ENTER para Continuar");
                Console.ReadLine ();
                Console.Clear ();

                Cliente cliente2 = new Cliente ("Ronmarinho", "123.456.123-12", "www.com.br");
                ContaCorrente contaCorrente2 = new ContaCorrente (123, 132, cliente2);
                Console.WriteLine ("ByteBank - Transferência");
                Console.WriteLine ($"Bem-vindo - {usuario.Nome}");
                Console.WriteLine ($"Agência: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
                Console.WriteLine ($"Saldo origem: {contaCorrente.Saldo}");
                Console.WriteLine ($"Saldo destino: {contaCorrente2.Saldo}");
                Console.Write ("Digite o valor da tranferência: ");
                valor = double.Parse (Console.ReadLine ());

                Console.WriteLine ("Tranferência efetuada com sucesso.");
                if (contaCorrente.Transferencia (contaCorrente2, valor)) { } else {
                    Console.WriteLine ("Operação não pode ser realizada.");
                }
                Console.WriteLine ($"Saldo origem atual: {contaCorrente.Saldo}");
                Console.WriteLine ($"Saldo destino atual: {contaCorrente2.Saldo}");
                System.Console.WriteLine ("Operação finalizada");
            }
        }
    }
}