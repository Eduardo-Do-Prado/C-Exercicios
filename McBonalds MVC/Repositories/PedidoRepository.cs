using System;
using System.IO;
using McBonalds_MVC.Models;
namespace McBonalds_MVC.Repositories {
    public class PedidoRepository 
    {
        private const string PATH = "Database/Pedido.csv";
        public PedidoRepository ()
        {
            if (!File.Exists (PATH)) 
            {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Pedido pedido) 
        {
            var linha = new string[] { PrepararRegistroCSV (pedido) };
            File.AppendAllLines (PATH, linha);
            return true;
        }

        private string PrepararRegistroCSV (Pedido pedido) 
        {
            Cliente cliente = pedido.Cliente;
            Hamburguer hamburguer = pedido.Hamburguer;
            Shake shake = pedido.Shake;

            return $"nome={cliente.Nome};endereco={cliente.Endereco};telefone={cliente.Telefone};email={cliente.Email};hamburguer_nome={hamburguer.Nome};hamburguer_preco={hamburguer.Preco};shake_nome={shake.Nome};shake_preco={shake.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}";

        }
    }
}