using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter o ritmo dos Tambores.");
            return true;
        }
}
}