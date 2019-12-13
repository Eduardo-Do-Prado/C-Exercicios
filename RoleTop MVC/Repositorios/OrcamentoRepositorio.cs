using System;
using System.Collections.Generic;
using System.IO;
using RoleTop_MVC.Models;

namespace RoleTop_MVC.Repositorios {
    public class OrcamentoRepositorio : Repositoriobase{
        private const string PATH = "Database/Orcamento.csv";
        public OrcamentoRepositorio () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Orcamento orcamento) {
            var quantidadeEventos = File.ReadAllLines (PATH).Length;
            orcamento.ID = (ulong) ++quantidadeEventos;
            var linha = new string[] { PrepararOrcamentoCSV (orcamento) };
            File.AppendAllLines (PATH, linha);
            return true;
        }
        public Cliente ObterPor (string email) {
            var linhas = File.ReadAllLines (PATH);
            foreach (var linha in linhas) {
                if (ExtrairValorDoCampo ("usuario", linha) == email) {
                    Cliente c = new Cliente ();
                    c.Usuario = ExtrairValorDoCampo ("usuario", linha);
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
        public void Aprovar( string ID )
        {
            var linhas = File.ReadAllLines(PATH);
            for(int i =0; i < linhas.Length; i++)
            {
                if(ExtrairValorDoCampo("id",linhas[i]) == ID){
                    Orcamento o = new Orcamento();
                    o.ID = ulong.Parse(ExtrairValorDoCampo("id",linhas[i]));
                    o.Cliente.Usuario = ExtrairValorDoCampo("usuario",linhas [i]);
                    o.DataEvento = DateTime.Parse(ExtrairValorDoCampo("dataEvento",linhas[i]));
                    o.Evento = ExtrairValorDoCampo("evento",linhas[i]);
                    o.QuantidadePessoas = double.Parse(ExtrairValorDoCampo("quantidadePessoas",linhas[i]));
                    o.Observacao = ExtrairValorDoCampo("observacao",linhas[i]);
                    o.Status = 1;
                    linhas[i] = PrepararOrcamentoCSV(o);
                    File.WriteAllLines(PATH, linhas);
                    break;
                }
            }
        }
        public void Cancelar( string ID )
        {
            var linhas = File.ReadAllLines(PATH);
            for(int i =0; i < linhas.Length; i++)
            {
                if(ExtrairValorDoCampo("id",linhas[i]) == ID){
                    Orcamento o = new Orcamento();
                    o.ID = ulong.Parse(ExtrairValorDoCampo("id",linhas[i]));
                    o.Cliente.Usuario = ExtrairValorDoCampo("usuario",linhas [i]);
                    o.DataEvento = DateTime.Parse(ExtrairValorDoCampo("dataEvento",linhas[i]));
                    o.Evento = ExtrairValorDoCampo("evento",linhas[i]);
                    o.QuantidadePessoas = double.Parse(ExtrairValorDoCampo("quantidadePessoas",linhas[i]));
                    o.Observacao = ExtrairValorDoCampo("observacao",linhas[i]);
                    o.Status = 1;
                    linhas[i] = PrepararOrcamentoCSV(o);
                    File.WriteAllLines(PATH, linhas);
                    break;
                }
            }
        }
        public List<Orcamento> ObterEventosCliente( string NomeCliente )
        {
            List<Orcamento> Eventos = new List<Orcamento>();
            var linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                if(ExtrairValorDoCampo("usuario",linha) == NomeCliente){
                    Orcamento o = new Orcamento();
                    o.ID = ulong.Parse(ExtrairValorDoCampo("id",linha));
                    o.Cliente.Usuario = ExtrairValorDoCampo("usuario",linha);
                    o.DataEvento = DateTime.Parse(ExtrairValorDoCampo("dataEvento",linha));
                    o.Evento = ExtrairValorDoCampo("evento",linha);
                    o.QuantidadePessoas = double.Parse(ExtrairValorDoCampo("quantidadePessoas",linha));
                    o.Status = uint.Parse(ExtrairValorDoCampo("status",linha));
                    Eventos.Add(o);
                }
            }
            return Eventos;
        }
        public List<Orcamento> ObterTodosEventosPendentes( )
        {
            List<Orcamento> Eventos = new List<Orcamento>();
            var linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                if(ExtrairValorDoCampo("status",linha) == "0"){
                    Orcamento o = new Orcamento();
                    o.ID = ulong.Parse(ExtrairValorDoCampo("id",linha));
                    o.Cliente.Usuario = ExtrairValorDoCampo("usuario",linha);
                    o.DataEvento = DateTime.Parse(ExtrairValorDoCampo("dataEvento",linha));
                    o.Evento = ExtrairValorDoCampo("evento",linha);
                    o.QuantidadePessoas = double.Parse(ExtrairValorDoCampo("quantidadePessoas",linha));
                    o.Status = uint.Parse(ExtrairValorDoCampo("status",linha));
                    Eventos.Add(o);
                }
            }
            return Eventos;
        }
        private string PrepararOrcamentoCSV (Orcamento orcamento) {
            return $"id={orcamento.ID};dataEvento={orcamento.DataEvento};evento={orcamento.Evento};quantidadePessoas={orcamento.QuantidadePessoas};status={orcamento.Status}";}
    }
}