using System;

namespace A_e_B {
    class Program {
        static void Main (string[] args) {
            double ValorA;
            double ValorB;
            Console.WriteLine ("Digite o valor para A");
            ValorB = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o valor para B");
            ValorA = double.Parse (Console.ReadLine ());


            System.Console.WriteLine("O valor de B é {0}", ValorB);
            System.Console.WriteLine("O valor de A é {0}", ValorA);
        }
    }
}