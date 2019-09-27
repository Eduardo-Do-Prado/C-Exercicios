using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
        aluno aluno1 = new aluno("Alexandre", "123.456.789-00", "prog1");
        aluno aluno2 = new aluno("Cesar", "987.654.321-9");
        string nome_do_aluno = aluno1.nome;
        string cpf_do_aluno = aluno1.cpf;
        Console.WriteLine ($"o nome do aluno é {nome_do_aluno}");
        Console.WriteLine ($"o CPF do aluno é {cpf_do_aluno}");
        Console.WriteLine ($"o curso do aluno é {aluno1.curso}");
        double[] notas = aluno1.getNotas();
        Console.Write("Notas: ");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(notas[i] + " ");
        }
        Console.Writeline();
        aluno1.notas.setNotas(1,8.0);

        Console.WriteLine ($"o nome do aluno2 é {aluno2.nome}");
        Console.WriteLine ($"o CPF do aluno2 é {aluno2.cpf}");
        Console.WriteLine ($"o curso do aluno2 é {aluno2.curso}");      
        }
    }
}
