using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPET : Lixo, IPlastico
    {
        public bool LixoPlastico()
        {
            System.Console.WriteLine("Lixeira: Plástico / Cor: Vermelha ");
            return true;
        }
    }
}