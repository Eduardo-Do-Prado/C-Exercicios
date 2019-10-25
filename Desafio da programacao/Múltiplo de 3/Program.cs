using System;

namespace Múltiplo_de_3 {
    class Program {
        static void Main (string[] args) {
            int N;

            System.Console.WriteLine ("Digite um número: ");
            N = int.Parse (Console.ReadLine ());

            if (N % 3 == 0)
            {
                System.Console.WriteLine("Esse número é múltiplo de 3");
            }else
            {
            System.Console.WriteLine("Esse número não é últiplo de 3");
            }
        }
    }
}