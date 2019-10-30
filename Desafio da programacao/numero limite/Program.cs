using System;

namespace numero_limite
{
    class Program
    {
        static void Main(string[] args) {
            double N;

            System.Console.WriteLine("Digite o número limite: ");
            N = double.Parse(Console.ReadLine());
        for (double i = 1; i < N; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine ("{0}", i);
                }
            }
        }
    }
}