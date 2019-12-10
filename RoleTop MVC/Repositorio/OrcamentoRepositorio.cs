using System.IO;
using RoleTop_MVC.Models;

namespace RoleTop_MVC.Repositorio {
    public class OrcamentoRepositorio {
        private const string PATH = "Database/Orcamento.csv";
        public OrcamentoRepositorio () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Orcamento orcamento) {
            var linha = new string[] { PrepararOrcamentoCSV (orcamento) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        private string PrepararOrcamentoCSV (Orcamento orcamento) {
            return $"nome={orcamento.Nome};email={orcamento.Email};telefone={orcamento.Telefone};cpf={orcamento.CPF};data_evento={orcamento.DataEvento};evento{orcamento.Evento};quantidade_pessoas{orcamento.QuantidadePessoas};observacao{orcamento.Observacao}";
        }
    }
}