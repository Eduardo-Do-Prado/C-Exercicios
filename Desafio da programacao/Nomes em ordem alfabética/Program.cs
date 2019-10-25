using System;
using System.Collections.Generic;

namespace Nomes_em_ordem_alfabética
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;

            System.Console.WriteLine("Digite o primeiro nome: ");
            nome1 = Console.ReadLine();

            System.Console.WriteLine("Digite o segundo nome: ");
            nome2 = Console.ReadLine();
            Console.Clear();
            
            System.Console.WriteLine("Nomes em ordem alfabética");
            List<string> Lista = new List<string> ();

            Lista.Add(nome1) ;
            Lista.Add(nome2);

            Lista.Sort();

            foreach (string item in Lista)
            System.Console.WriteLine(item);
            
        }
    }
}
