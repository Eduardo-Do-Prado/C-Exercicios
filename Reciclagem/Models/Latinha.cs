using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models 
{
    public class Latinha : Lixo, IMetal
    {
        public bool LixoMetalico()
        {
            System.Console.WriteLine("Lixeira: Metal / Cor: Amarela ");
            return true;
        }
    }
}