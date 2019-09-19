using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            string oper;

            Console.WriteLine ("Digite sua idade");
            num1 = int.Parse(Console.ReadLine());

            oper = Console.ReadLine(); 

            Console.WriteLine ($"{num1} * {12} = {num1 * 12}");
            Console.WriteLine ($"{num1} * {365} = {num1 * 365}");
            Console.WriteLine ($"{num1} * {8760} = {num1 * 8760}");
            Console.WriteLine ($"{num1} * {525600} = {num1 * 525600}");
        }
    }
}

