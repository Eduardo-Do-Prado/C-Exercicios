using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes de Guitarra.");
            return true;
        }
        public bool TocarSolo(){
            System.Console.WriteLine("Tocando solo de Guitarra.");
            return true;
        }
    }
}