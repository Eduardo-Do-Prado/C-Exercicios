using System;

namespace data_de_nascimento {
    class Program {
        static void Main (string[] args) {
            int anoAtual = 2019;
            int anoNasc = 0;
            int idade;

            Console.WriteLine ("Qual o seu ano de nascimento? ");
            anoNasc = int.Parse (Console.ReadLine ());
            idade = anoAtual - anoNasc;

            if (idade <= 2) {
                Console.WriteLine ("Você é um recém nascido!");
            } else if ((idade >= 3) && (idade <= 11)) {
                Console.WriteLine ("Você é uma criança!");
            } else if ((idade >= 12) && (idade <= 19)) {
                Console.WriteLine ("Você é um adolescente!");
            } else if ((idade >= 20) && (idade <= 65)) {
                Console.WriteLine ("Você é um adulto");
            } else if (idade > 65) {
                Console.WriteLine ("Você é um idoso!");
            }
        }
    }
}