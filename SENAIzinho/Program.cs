using System;
using System.Collections.Generic;
using System.IO;

namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {
            Aluno[] alunos = new Aluno[100];
            int alunosCadastrados = 0;
            Sala[] salas = new Sala[10];
            int salasCadastradas = 0;
            string Opcao;

            do {
                Console.WriteLine ("================================================================================================================================================================");
                System.Console.WriteLine ("                                                            Seja Bem-vindo(a)");
                Console.WriteLine ("================================================================================================================================================================");
                System.Console.WriteLine ();

                System.Console.WriteLine ("Qual operação deseja realizar? ");
                System.Console.WriteLine ("(1) Cadastrar Aluno(a) | (2) Cadastrar Sala | (3) Alocar Aluno(a) | (4) Remover Aluno(a) | (5) Verificar Salas | (6) Verificar Alunos | (0) Sair ");
                Opcao = Console.ReadLine ();
                Console.Clear ();
                Aluno aluno = new Aluno ();
                Sala sala = new Sala ();

                switch (Opcao) {
                    case "1":

                        System.Console.WriteLine ("Digite o nome completo do aluno(a): ");
                        aluno.Nome = Console.ReadLine ();

                        System.Console.WriteLine ("Digite a data de nascimento do aluno(a): ");
                        aluno.DataNascimento = DateTime.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("Digite o curso desejado: ");
                        aluno.Curso = Console.ReadLine ();

                        alunos[alunosCadastrados] = aluno;
                        alunosCadastrados++;

                        System.Console.WriteLine ("O cadastro foi realizado com sucesso!");

                        System.Console.WriteLine();
                        System.Console.WriteLine ("Pressione ENTER para retornar ao menu");
                        Console.ReadLine ();
                        Console.Clear ();

                        break;
                    case "2":
                        System.Console.WriteLine ("A sala foi adicionada ao sistema!");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Pressione ENTER para retornar ao menu");
                        Console.ReadLine ();
                        Console.Clear ();
                        break;
                    case "3":
                        System.Console.WriteLine ("Digite o nome do aluno(a): ");
                        aluno.Nome = Console.ReadLine ();

                        System.Console.WriteLine ("Digite a sala atual do aluno(a): ");
                        sala.NumeroSala = int.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("O Aluno foi alocado com sucesso!");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Pressione ENTER para retornar ao menu");
                        Console.ReadLine ();
                        Console.Clear ();
                        break;
                    case "4":
                        System.Console.WriteLine ("Digite o nome completo do aluno(a): ");
                        aluno.Nome = Console.ReadLine ();

                        
                        System.Console.WriteLine ("O aluno(a) foi retirado do sistema");
                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Pressione ENTER para retornar ao menu");
                        Console.ReadLine ();
                        Console.Clear ();
                        break;
                    case "5":
                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Pressione ENTER para retornar ao menu");
                        Console.ReadLine ();
                        Console.Clear ();
                        
                        break;
                    case "6":
                        
                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Pressione ENTER para retornar ao menu");
                        Console.ReadLine ();
                        Console.Clear ();
                        break;
                    default:
                        Console.WriteLine ("Operação encerrada");
                        break;
                }
            } while (Opcao != "0");
        }
    }
}