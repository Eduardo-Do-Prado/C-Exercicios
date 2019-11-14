using System;
using System.Collections.Generic;
using System.IO;
using McBonalds_MVC.Models;

namespace McBonalds_MVC.Repositories
{
    public class HamburgerRepository
    {
        private const string PATH = "Database/Hamburger.csv";

        public HamburgerRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public List<Hamburger> ObterTodos()
        {
            List<Hamburger> hamburgeres = new List<Hamburger>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Hamburger h = new Hamburger();
                string[] dados = linha.Split(";");
                h.Nome = dados [0];
                h.Preco = double.Parse (dados[1]);
                hamburgeres.Add(h);
            }
            return hamburgeres;
        }

        
    }
}