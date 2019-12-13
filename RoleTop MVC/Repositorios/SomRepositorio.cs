using System.Collections.Generic;
using System.IO;
using RoleTop_MVC.Models;

namespace RoleTop_MVC.Repositorios
{
    public class SomRepositorio
    {
        private const string PATH = "Database/Som.csv";
        public SomRepositorio(){
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public double ObterPrecoDe(string tipoSom){
            var lista = ObterTodos();
            double preco = 0.0;

            foreach(var item in lista){
                if(item.Tipo.Equals(tipoSom)){
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Som> ObterTodos(){
            List<Som> som = new List<Som>();

            string[] linhas =  File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                Som s = new Som();
                string[] dados = linha.Split(";");
                s.Tipo = dados[0];
                s.Preco = double.Parse(dados[1]);
                som.Add(s);
            }
            return som;
        }
    }
}