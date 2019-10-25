using System;

namespace Planetas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int peso;
            double total;

            Console.WriteLine ("Digite o seu peso em Kg: ");
            peso = int.Parse (Console.ReadLine ());

            total = peso * 0.37;
            Console.WriteLine ("O valor em Mercúrio é: {0}", total);

            total = peso * 0.88;
            Console.WriteLine ("O valor em Vênus é: {0}", total);
            
            total = peso * 0.38;
            Console.WriteLine ("O valor em Marte é: {0}", total);

            total = peso * 2.64;
            Console.WriteLine ("O valor em Júpiter é: {0}", total);

            total = peso * 1.15;
            Console.WriteLine ("O valor em Saturno é: {0}", total);

            total = peso * 1.17;
            Console.WriteLine ("O valor em Urano é: {0}", total);
        }
    }
}
