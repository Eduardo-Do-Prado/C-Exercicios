using System;
using System.Collections.Generic;
using System.Text;
using EscolaDeRock.Interfaces;


namespace EscolaDeRock.Models
{
    class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Tocando Ritmo do Violão.");
            return true;
        }

        public bool TocarAcordes()
        {

            System.Console.WriteLine("Tocar Acordes: ");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do Violão.");
            return true;
        }
    }
}
