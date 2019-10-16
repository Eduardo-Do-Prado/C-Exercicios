using System;
using System.Collections.Generic;
using System.Text;
using EscolaDeRock.Models;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock
{
    enum FormacaoEnum : int{
        TRIO = 3,
        QUARTETO
    };
    enum InstrumentosEnum : int{
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TAMBORES,
        TECLADO,
        VIOLAO 
    };
    enum CategoriaEnum :int {
        HARONIA,
        PERCUSSAO,
        MELODIA
    };
    class program
    {
        static void Main(string[] args){
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "     - 0       ",
                "     - 1       "
            };

            int opcaoFormacao = 0;
            string menubar = "====================================";

            do {
                bool formacaoEscolhida = false;
                
                do {
                    Console.Clear();
                    System.Console.WriteLine(menubar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Seja Bem-Vindo");
                    System.Console.WriteLine("Escolha uma formação: ");
                    Console.ResetColor();
                    System.Console.WriteLine(menubar);

                    for (int i = 0; i < opcaoFormacao.Count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                        if(opcaoFormacaoSelecionada == i){

                        }
                    }
                }
            }
        }
    }
}