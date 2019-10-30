using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double Peso;
            double Peso2;
            double Altura;
            double Altura2;
            double IMC;

            Console.WriteLine("Digite o seu peso: ");
            Peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite sua altura: ");
            Altura = double.Parse(Console.ReadLine());

            Altura2 = Altura * Altura;
            Peso2 = Peso * 10000;
            IMC =  Peso2 / Altura2;

            if (IMC <= 20)
            {
                System.Console.WriteLine("Abaixo do Peso");
                Console.WriteLine("O seu IMC é de  {0}", IMC);
            }
            else if ((IMC >= 20) && (IMC <= 25))
            {
                System.Console.WriteLine("Normal");
                Console.WriteLine("O seu IMC é de  {0}", IMC);
            }
            else if ((IMC >= 25) && (IMC <= 30))
            {
                System.Console.WriteLine("Excesso de peso");
                Console.WriteLine("O seu IMC é de  {0}", IMC);
            }
            else if ((IMC >= 30) && (IMC <= 35))
            {
                System.Console.WriteLine("Obesidade");
                Console.WriteLine("O seu IMC é de  {0}", IMC);
            }
            else if (IMC > 35)
            {
                System.Console.WriteLine("Obesidade Mórbita");
                Console.WriteLine("O seu IMC é de  {0}", IMC);
            }
        }
    }
}
