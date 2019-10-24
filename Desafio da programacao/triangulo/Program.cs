using System;

namespace triangulo {
    class Program {
        static void Main (string[] args) {
            int altu;
            int taman;
            int compr;

            do {
                Console.WriteLine ("Digite o Tamanho: ");
                altu = int.Parse (Console.ReadLine ());

                scanf ("%d", & n);
                for (compr = 1; compr <= altu; compr++) {
                    for (taman = 1; taman <= compr; taman++)
                        Console.Write ("*");
                    Console.Write ("\n");
                }
            }
        }
    }
}