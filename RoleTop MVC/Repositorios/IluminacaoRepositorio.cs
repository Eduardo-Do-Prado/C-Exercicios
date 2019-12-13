using System.Collections.Generic;
using System.IO;
using RoleTop_MVC.Models;

namespace RoleTop_MVC.Repositorios
{
    public class IluminacaoRepositorio
    {
        private const string PATH = "Database/Iluminacao.csv";
        public IluminacaoRepositorio(){
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public double ObterPrecoDe(string tipoIluminacao){
            var lista = ObterTodos();
            double preco = 0.0;

            foreach(var item in lista){
                if(item.Tipo.Equals(tipoIluminacao)){
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Iluminacao> ObterTodos(){
            List<Iluminacao> iluminacao = new List<Iluminacao>();

            string[] linhas =  File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                Iluminacao i = new Iluminacao();
                string[] dados = linha.Split(";");
                i.Tipo = dados[0];
                i.Preco = double.Parse(dados[1]);
                iluminacao.Add(i);
            }
            return iluminacao;
        }
    }
}