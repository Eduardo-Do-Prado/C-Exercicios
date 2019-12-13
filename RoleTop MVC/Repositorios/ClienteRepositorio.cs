using System;
using System.IO;
using RoleTop_MVC.Models;

namespace RoleTop_MVC.Repositorios 
{
    public class ClienteRepositorio : Repositoriobase
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepositorio() 
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public bool Inserir (Cliente cliente) 
        {
            var linha = new string[] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines (PATH, linha);
            return true;
        }
        public Cliente ObterPor (string Email) 
        {
            var linhas = File.ReadAllLines (PATH);
            foreach (var linha in linhas) 
            {
                if (ExtrairValorDoCampo ("email", linha)== Email) 
                {
                    Cliente c = new Cliente ();
                    c.Usuario = ExtrairValorDoCampo("usuario",linha);
                    c.Nome = ExtrairValorDoCampo ("nome", linha);
                    c.Email = ExtrairValorDoCampo ("email", linha);
                    c.Telefone = ExtrairValorDoCampo ("telefone", linha);
                    c.CPF = ExtrairValorDoCampo ("cpf", linha);
                    c.DataNascimento = DateTime.Parse (ExtrairValorDoCampo ("dataNascimento", linha));
                    c.Senha = ExtrairValorDoCampo ("senha", linha);
                    return c;
                }
            }
            return null;
        }
        private string PrepararRegistroCSV (Cliente cliente) {
            return $"usuario={cliente.Usuario};nome={cliente.Nome};email={cliente.Email};telefone={cliente.Telefone};cpf={cliente.CPF};dataNascimento={cliente.DataNascimento};senha={cliente.Senha}";
        }
    }
}