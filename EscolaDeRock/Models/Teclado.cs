using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models {
    class Teclado : InstrumentoMusical, IMelodia, IHarmonia {
        public bool TocarSolo () {
            System.Console.WriteLine ("Tocando solo do teclado.");
            return true;
        }
        public bool TocarAcordes () {
            System.Console.WriteLine ("Tocar arcordes do teclado.");
            return true;
        }
        
    }
}