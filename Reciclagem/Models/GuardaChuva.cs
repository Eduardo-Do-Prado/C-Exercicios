using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models 
{
    public class GuardaChuva : Lixo, IIndefenido
    {
        public bool LixoIndeterminado()
        {
            System.Console.WriteLine("Lixeira: Indeterminado / Cor: Cinza ");
            return true;
        }
    }
}