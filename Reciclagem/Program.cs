using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem {

    enum ItensEnum : uint {
        GARRAFA = 1,
        GARRAFA_PET = 2,
        GUARDA_CHUVA = 3,
        LATINHA = 4,
        PAPELAO = 5,
        POTE_MANTEIGA = 6
    }

    enum CategoriaEnum : uint {
        INDEFINIDO,
        METAL,
        ORGANICO,
        PAPEL,
        PLASTICO,
        VIDRO
    }

    class Program {
        static void Main (string[] args) {
            #region MyRegion
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames (typeof (ItensEnum));
            string[] itensMenuCategoria = Enum.GetNames (typeof (CategoriaEnum));

            var opcoesItens = new List<string> () {
                "    - 0                         ",
                "    - 1                         ",
                "    - 2                         ",
                "    - 3                         ",
                "    - 4                         ",
                "    - 5                         "
            };

            int opcaoItemSelecionada = 0;

            string menuBar = "=================================================";

            #endregion

            do {
                bool ItemEscolhido = false;
                #region Controla o menu dos itens.
                do {
                    Console.Clear ();

                    System.Console.WriteLine (menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    System.Console.WriteLine ("     Seja bem-vindo(a) ao Centro de Reciclagem   ");
                    System.Console.WriteLine ("        Escolha um item para ser reciclado:      ");
                    Console.ResetColor ();
                    System.Console.WriteLine (menuBar);

                    #region Troca a cor do menu.
                    for (int i = 0; i < opcoesItens.Count; i++) {
                        string titulo = TratarTituloMenu (itensMenuPrincipal[i]);

                        if (opcaoItemSelecionada == i) {
                            DestacarOpcao (opcoesItens[opcaoItemSelecionada].Replace ("-", ">").Replace (i.ToString (), titulo));
                        } else {
                            System.Console.WriteLine (opcoesItens[i].Replace (i.ToString (), titulo));
                        }
                    }

                    #region Lê a tecla pressionada pelo usuário e verifica a opção selecionada.
                    var key = Console.ReadKey (true).Key;

                    switch (key) {
                        case ConsoleKey.UpArrow:
                            opcaoItemSelecionada = opcaoItemSelecionada == 0 ? opcaoItemSelecionada : --opcaoItemSelecionada;
                            break;

                        case ConsoleKey.DownArrow:
                            opcaoItemSelecionada = opcaoItemSelecionada == opcoesItens.Count - 1 ? opcaoItemSelecionada : ++opcaoItemSelecionada;
                            break;

                        case ConsoleKey.Enter:
                            ItemEscolhido = true;
                            break;
                    }
                    #endregion

                    #endregion

                } while (!ItemEscolhido);

                #endregion
            } while (!querSair);
        }

        public static void DestacarOpcao (string opcao) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine (opcao);
            Console.ResetColor ();
        }

        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }
    }
}