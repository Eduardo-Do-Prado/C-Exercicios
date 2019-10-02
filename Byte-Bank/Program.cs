using System;
using Cliente.Models;

namespace Byte_Bank {
    class Program {
        static void Main (string[] args) {
            bool ClienteNaoDesistiu = true;
            do {
                System.Console.WriteLine ("=================================================================");
                System.Console.WriteLine ("                   Seja bem-vindo(a) á Byte-Bank");
                System.Console.WriteLine ("=================================================================");

                System.Console.WriteLine ("Aperte 1 para iniciar o cadastro");
                System.Console.WriteLine ("Aperte 2 para encerrar o cadastro");

                string OpcaoCliente = Console.ReadLine ();

                switch (OpcaoCliente) {
                    case "1":
                        Console.Clear ();

                        Usuario usuario = new Usuario ();

                        System.Console.WriteLine ("Digite seu nome completo: ");
                        usuario.Nome = Console.ReadLine ();

                        System.Console.WriteLine ("Digite seu CPF: ");
                        usuario.CPF = Console.ReadLine();
                        
                        System.Console.WriteLine("Digite seu Email: ");
                        usuario.Email = Console.ReadLine();
                        
                        System.Console.WriteLine("Digite sua senha: ");
                        usuario.Senha = Console.ReadLine();







                case "0":
                        ClienteNaoDesistiu = false;
                        break;

                    default:
                        System.Console.WriteLine ("Comando Desconhecido");
                        break;
                }
            }while (ClienteNaoDesistiu);
        }
    }
}