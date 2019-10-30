using System;

namespace triangulo {
    class Program {
        static void Main (string[] args) {
            int altu;
            int taman;
            int compr;
            string func;

            do {
                Console.Clear();
                Console.WriteLine ("Digite o Tamanho: ");
                altu = int.Parse (Console.ReadLine ());
                for (compr = altu; compr >= 0; compr = compr - 1) {
                    for (taman = 1; taman <= compr; taman++)
                        Console.Write ("*");
                    Console.Write ("\n");
                }
                System.Console.WriteLine ("1- tentar novamente");
                func = Console.ReadLine ();

            } while (func == "1");
        }
    }
}