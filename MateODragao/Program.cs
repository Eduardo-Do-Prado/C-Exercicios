using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("          Mate o Dragão");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1 - Iniciar Jogo");
                System.Console.WriteLine (" 0 - Sair do Jogo");

                string opaoJogador = Console.ReadLine ();

                switch (opaoJogador) {
                    case "1":
                        Console.Clear ();
                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "Seu";
                        guerreiro.Sobrenome = "Jorge";
                        guerreiro.CidadeNatal = "Capadócia";
                        guerreiro.DataNascimento = DateTime.Parse ("08/06/1370");
                        guerreiro.FerramentaAtaque = "Lança";
                        guerreiro.FerramentaPrtoecao = "Escudo (Monsters)";
                        guerreiro.Forca = 2;
                        guerreiro.Destreza = 4;
                        guerreiro.Inteligencia = 2;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Dragonildo";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*INICIO - Primeiro Diálogo */
                        System.Console.WriteLine ($"{guerreiro.Sobrenome.ToUpper()}: {dragao.Nome}, Seu Zé Ruela, Seu zoreiudo! Vc vai perder pra mim ótareo; É OS GURI FIU FIU");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Vai nessa champs. JOGOU AONDE?");
                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte Enter para prosseguir");
                        Console.ReadLine ();

                        /*FIM - Primeiro Diálogo */

                        /*INICIO - Segundo Diálogo */
                        Console.Clear ();
                        System.Console.WriteLine ($"{guerreiro.Sobrenome.ToUpper()}: Eu sou {guerreiro.Nome} {guerreiro.Sobrenome}!, ó criatura morfética!");
                        System.Console.WriteLine ($"{guerreiro.Sobrenome.ToUpper()}: Vim da {guerreiro.CidadeNatal} para passar o sarrafo em você");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: QUEM? De onde? Bom que seja... fritar-te-ei e devorar-te-ei!");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte Enter para prosseguir");
                        Console.ReadLine ();
                        /*FIM - Segundo Diálogo */
                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
                        bool jogadorNaoCorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia = guerreiro.Destreza;

                        /*INICIO - TRETA*/
                        if (jogadorAtacaPrimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("***Turno do Jogador***");
                            System.Console.WriteLine ("Escolha sua ação");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int NumeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int NumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Sobrenome.ToUpper()}: Tomou pra deixa de ser besta!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ("============================================");
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrooouuuu");
                                    }

                                    System.Console.WriteLine ();
                                    break;

                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Sobrenome.ToUpper()}: Meti o pé ");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: É isso");
                                    break;
                            }
                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Aperte ENTER para posseguir");
                            Console.ReadLine ();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                                Console.Clear ();
                                System.Console.WriteLine ("***Turno do Dragão**");
                                Random geradorNumeroAleatorio = new Random ();
                                int NumeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                int NumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: fogo no rabo do narguleiro kkkkk");
                                    guerreiro.Vida -= dragao.Forca;
                                    System.Console.WriteLine ("============================================");
                                    System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                } else {
                                    System.Console.WriteLine ($"{guerreiro.Sobrenome.ToUpper()}: É só isso? Pathetic");
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para posseguir");
                                Console.ReadLine ();

                                /*INICIO - Turno Jogador */
                                Console.Clear();
                                System.Console.WriteLine ("Turno do Jogador");
                                System.Console.WriteLine ("Escolha sua ação");
                                System.Console.WriteLine (" 1 - Atacar");
                                System.Console.WriteLine (" 2 - Fugir");

                                opcaoBatalhaJogador = Console.ReadLine ();

                                switch (opcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatorio = new Random ();
                                        NumeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                        NumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                        guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                        dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                        if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Sobrenome.ToUpper()}: Tomou pra deixa de ser besta!");
                                            dragao.Vida -= poderAtaqueGuerreiro + 5;
                                            System.Console.WriteLine ("============================================");
                                            System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrooouuuu");
                                        }

                                        System.Console.WriteLine ();
                                        break;
                                
                                    case "2":
                                        jogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Sobrenome.ToUpper()}: Meti o pé ");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: É isso");
                                        break;
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para posseguir");
                                Console.ReadLine ();
                                /*FIM - Turno Jogador */
                            }
                        }
                        /*FIM - TRETA */

                        break;

                    case "0":
                        jogadorNaoDesistiu = false;
                        break;

                    default:
                        System.Console.WriteLine ("Comando Desconhecido");
                        break;

                }
            } while (jogadorNaoDesistiu);

        }
    }
}