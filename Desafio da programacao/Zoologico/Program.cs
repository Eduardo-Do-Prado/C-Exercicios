﻿using System;
using System.Linq;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace ZooLogico {
    class Program {
        static void Main (string[] args) {
            var encerrouPrograma = false;
            #region Loop Principal
            do {
                #region Menu Principal
                var codigo = 0;
                Console.Clear ();
                System.Console.WriteLine ("===============================");
                System.Console.WriteLine ("|  Bem-vindo ao ZooLógico!  |");
                System.Console.WriteLine ("===============================");
                // Gerar os itens do menu de forma automática
                foreach (var item in Arca.Models.Values) {
                    System.Console.WriteLine ($"{" ",5}{++codigo}. {item.GetType().Name}");
                }
                #endregion
                System.Console.Write ($"\n{" ",2}Digite o código do animal: ");

                // Testando se o usuário digitou um código correto ou não
                try {
                    var opcaoUsuario = int.Parse (Console.ReadLine ());
                    var animal = Arca.Models[opcaoUsuario];
                    ClassificarAnimal (animal);
                } catch (Exception) {
                    System.Console.WriteLine ("Por favor, digite um código válido");
                    Console.ReadLine ();

                }
            } while (!encerrouPrograma);
            #endregion
        }
        public static void ClassificarAnimal (Animal animal) {
            // Esse @ é para que possamos usar o nome interface para a variável, que é uma palavra reservada do C#!
            var classe = animal.GetType ();
            var @interface = classe.GetInterfaces ().FirstOrDefault (); {

                if ((typeof (IAquario)).Equals (@interface)) {
                    System.Console.WriteLine ($":::{classe.Name} pode ir para a Piscina:::");
                } else if ((typeof (ICasaArvore)).Equals (@interface)) {
                    System.Console.WriteLine ($":::{classe.Name} pode ir para a Casa na Árvore:::");
                } else if ((typeof (IAquario)).Equals (@interface)) {
                    System.Console.WriteLine ($":::{classe.Name} pode ir para o Aquário:::");
                } else if ((typeof (IPiscinaGelada)).Equals (@interface)) {
                    System.Console.WriteLine ($":::{classe.Name} pode ir para a Piscina Gelada:::");
                } else if ((typeof (ICavernaPedra)).Equals (@interface)) {
                    System.Console.WriteLine ($":::{classe.Name} pode ir para os Pastos ou Caverna de Pedra:::");
                } else if ((typeof (IGaiola)).Equals (@interface)) {
                    System.Console.WriteLine ($":::{classe.Name} pode ir para a Gaiola:::");
                }

                Console.ReadLine ();

            }

        }
    }
}