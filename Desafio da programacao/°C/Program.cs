using System;

namespace _C
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            double F;

            Console.WriteLine("Digite o a temperatura em graus centígrados");
            C = int.Parse(Console.ReadLine());

            F = 1.8 * C + 32;
            System.Console.WriteLine("A temperatura em °C é: {0}", F);
        }
    }
}
