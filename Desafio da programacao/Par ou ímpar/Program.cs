using System;

namespace Par_ou_ímpar {
    class Program {
        static void Main (string[] args) {
            int x;

                Console.WriteLine ("Digite um numero");
                x = int.Parse (Console.ReadLine ());

                if (x % 2 == 0) {
                    Console.WriteLine ("Número Par");

                } else {
                    Console.WriteLine ("Número Ímpar");
                }
        }
    }
}