using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models 
{
    public class PoteManteiga : Lixo, IPlastico
    {
        public bool LixoPlastico()
        {
            System.Console.WriteLine("Lixeira: Plástico / Cor: Vermelha ");
            return true;
        }
    }
}