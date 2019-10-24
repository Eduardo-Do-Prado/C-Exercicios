using System;

namespace _0_a_10_impar {
    class Program {
        static void Main (string[] args) {
            for (double i = 2; i < 100; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine ("{0}", i);
                }
            }
        }
    }
}