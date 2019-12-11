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
                if (ExtrairValorDoCampo ("login", linha) == email) {
                    Cliente c = new Cliente ();
                    c.Usuario = ExtrairValorDoCampo ("Usuario", linha);
                    c.Nome = ExtrairValorDoCampo ("Nome", linha);
                    c.Email = ExtrairValorDoCampo ("Email", linha);
                    c.Telefone = ExtrairValorDoCampo ("Telefone", linha);
                    c.CPF = ExtrairValorDoCampo ("CPF", linha);
                    c.DataNascimento = DateTime.Parse (ExtrairValorDoCampo ("DataNascimento", linha));
                    c.Senha = ExtrairValorDoCampo ("Senha", linha);
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
                if(ExtrairValorDoCampo("ID",linhas[i]) == ID){
                    Orcamento o = new Orcamento();
                    o.ID = ulong.Parse(ExtrairValorDoCampo("ID",linhas[i]));
                    o.Organizador = ExtrairValorDoCampo("Organizador",linhas[i]);
                    o.DataEvento = DateTime.Parse(ExtrairValorDoCampo("DataEvento",linhas[i]));
                    o.Evento = ExtrairValorDoCampo("Evento",linhas[i]);
                    o.QuantidadePessoas = double.Parse(ExtrairValorDoCampo("QuantidadePessoas",linhas[i]));
                    o.Observacao = ExtrairValorDoCampo("Observacao",linhas[i]);
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
                if(ExtrairValorDoCampo("ID",linhas[i]) == ID){
                    Orcamento o = new Orcamento();
                    o.ID = ulong.Parse(ExtrairValorDoCampo("ID",linhas[i]));
                    o.Organizador = ExtrairValorDoCampo("Organizador",linhas[i]);
                    o.DataEvento = DateTime.Parse(ExtrairValorDoCampo("DataEvento",linhas[i]));
                    o.Evento = ExtrairValorDoCampo("Evento",linhas[i]);
                    o.QuantidadePessoas = double.Parse(ExtrairValorDoCampo("QuantidadePessoas",linhas[i]));
                    o.Observacao = ExtrairValorDoCampo("Observacao",linhas[i]);
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
                if(ExtrairValorDoCampo("Organizador",linha) == NomeCliente){
                    Orcamento o = new Orcamento();
                    o.ID = ulong.Parse(ExtrairValorDoCampo("ID",linha));
                    o.Organizador = ExtrairValorDoCampo("Organizador",linha);
                    o.DataEvento = DateTime.Parse(ExtrairValorDoCampo("DataEvento",linha));
                    o.Evento = ExtrairValorDoCampo("Evento",linha);
                    o.QuantidadePessoas = double.Parse(ExtrairValorDoCampo("QuantidadePessoas",linha));
                    o.Status = uint.Parse(ExtrairValorDoCampo("Status",linha));
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
                if(ExtrairValorDoCampo("Status",linha) == "0"){
                    Orcamento o = new Orcamento();
                    o.ID = ulong.Parse(ExtrairValorDoCampo("ID",linha));
                    o.Organizador = ExtrairValorDoCampo("Organizador",linha);
                    o.DataEvento = DateTime.Parse(ExtrairValorDoCampo("DataEvento",linha));
                    o.Evento = ExtrairValorDoCampo("Evento",linha);
                    o.QuantidadePessoas = double.Parse(ExtrairValorDoCampo("QuantidadePessoas",linha));
                    o.Status = uint.Parse(ExtrairValorDoCampo("Status",linha));
                    Eventos.Add(o);
                }
            }
            return Eventos;
        }
        private string PrepararOrcamentoCSV (Orcamento orcamento) {
            return $"ID={orcamento.ID};Organizador={orcamento.Organizador};DataEvento={orcamento.DataEvento};Evento={orcamento.Evento};QuantidadePessoas={orcamento.QuantidadePessoas};Status={orcamento.Status}";}
    }
}