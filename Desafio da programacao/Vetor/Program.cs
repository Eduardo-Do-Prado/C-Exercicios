﻿using System;

namespace Vetor_numérico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int pares = 0;
            int impares = 0;

            for(int cont = 0; cont <= 5; cont++){
                Console.Write("Digite um número: ");
                vetor[cont] = int.Parse(Console.ReadLine());

            }

            foreach (int num in vetor)
            {
                if(num%2 == 0){
                    //pares = pares + 1;
                    //pares += 1;
                    pares += 1;
                } else {
                    impares++;
                }
            }

            Console.WriteLine($"Você tem {pares} números pares e {impares} números mpares");
        }
    }
}
