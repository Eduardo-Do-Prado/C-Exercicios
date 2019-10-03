using System;
using Cadastro;

namespace ByteBank
{
    class Program
    {
        private static bool senhaOk;

        static void Main(string[] args)
        {
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine("         Seja bem-vindo(a) á ByteBank");
            System.Console.WriteLine("----------------------------------------------");

            System.Console.WriteLine($"Digite seu CPF: ");
            string Cpf = Console.ReadLine();
            
            System.Console.WriteLine($"Digite seu Nome: ");
            string Nome = Console.ReadLine();
            
            System.Console.WriteLine($"Digite seu Email: ");
            string Email = Console.ReadLine();
            
            Cliente login1 = new Cliente(Nome,Cpf,Email);

            do{
                System.Console.WriteLine("Digite sua Senha");
                string senha = Console.ReadLine();
                bool senhaOk = login1.TrocaSenha(senha);
                if(!senhaOk){
                    System.Console.WriteLine("Senha não atende aos requsitos ");
                } else {
                    System.Console.WriteLine("Senha Trocada com sucesso");
                }
            }while(!senhaOk);
        


        }
    }
}
