using System;

namespace Retangulo {
    class Program {
        static void Main (string[] args) {
            int Altura;
            int Base;
            double totald;
            double total;

            Console.WriteLine ("Digite o valor da base: ");
            Base = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o valor da altura: ");
            Altura = int.Parse (Console.ReadLine ());

            total = Base * Altura;
            Console.WriteLine ("O valor da área é: {0}", total);

            total = Base + Base + Altura + Altura;
            Console.WriteLine ("O valor da perímetro é: {0}", total);
            
            total = Base * Base + Altura * Altura;
            totald = Math.Sqrt(total);
            Console.WriteLine ("O valor da diagonal é: {0}", totald);

        }
    }
}