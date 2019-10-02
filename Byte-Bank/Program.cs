using System;
using Cliente.Models;

namespace Byte_Bank {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("=================================================================");
            System.Console.WriteLine ("                   Seja bem-vindo(a) á Byte-Bank");
            System.Console.WriteLine ("=================================================================");

            System.Console.WriteLine ("Cadastro de clientes");
            System.Console.WriteLine ();
            Console.Clear ();

            System.Console.WriteLine ("Digite seu nome completo: ");
            string Nome = Console.ReadLine ();

            System.Console.WriteLine ("Digite seu CPF: ");
            string CPF = Console.ReadLine ();

            System.Console.WriteLine ("Digite seu Email: ");
            string Email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (Nome, CPF, Email);
            bool trocouSenha = false;
            do{
                System.Console.WriteLine("Digite a senha: ");
                string senha = Console.ReadLine();
                bool senhaOK = cliente1.Trocasenha(senha);
                if (!senhaOK){
                    System.Console.WriteLine("senha nao atende os requisitos");
                }else{
                    System.Console.WriteLine("senha trocada com sucesso");
                }
            }while(!trocouSenha);
        }
    }
}