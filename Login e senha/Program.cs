using System;

namespace Login_e_senha
{
    class Program
    {
        static void Main(string[] args)
        {
          string login;
            string password;

            Console.WriteLine("Insira seu usuário: ");
            login = Console.ReadLine();

            Console.WriteLine("Insira sua senha: ");
            password = Console.ReadLine();

            if((login == "adm.")  && (password == "adm."))
                Console.WriteLine("Você é um administrador");
                else{
                    Console.WriteLine("Você é um usuário");
                }
        }
    }
}