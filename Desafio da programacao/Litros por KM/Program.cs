using System;

namespace Litros_por_KM {
    class Program {
        static void Main (string[] args) {
            double Vmed;
            double Tempo;
            double Litros;
            double Distancia;
            double Total;

            Console.WriteLine ("Digite a velocidade média em KM: ");
            Vmed = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite o Tempo que levará em minutos: ");
            Tempo = double.Parse (Console.ReadLine ());

            Total = Tempo * Vmed;
            Distancia = Total / 60;

            System.Console.WriteLine("A distância será de {0}", Distancia);

            Litros = Distancia / 12;
            System.Console.WriteLine("A quantidade de litros usados será de {0}", Litros);
        }
    }
}