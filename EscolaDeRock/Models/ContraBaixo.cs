using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo: InstrumentoMusical, IPercussao, IHarmonia {
        public bool ManterRitmo () {
            System.Console.WriteLine ("Manter Ritmo.");
            return true;
        }
        public bool TocarAcordes () {
            System.Console.WriteLine("Tocando acordes de contra baixo.");
            return true;
        }
    }
}