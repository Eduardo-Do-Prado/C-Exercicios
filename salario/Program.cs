using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumento;

            Console.WriteLine("Qual seu salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500){
                salario = salario * 0.3;

                salario += aumento;

                Console.WriteLine("Parabéns você ganhou um aumento!");
                Console.WriteLine("Seu novo salário é " + salario);
            }
            else {
                 Console.WriteLine("Desculpe, seu aumento salarial para você!");
            }
        }

    }
}
