using System;
using System.Collections.Generic;
using System.Text;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Bateria : InstrumentoMusical
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter o ritmo da Bateria.");
            return true;
        }
    }
}