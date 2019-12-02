using System.Collections.Generic;
using McBonalds_MVC.Models;

namespace McBonalds_MVC.ViewModels 
{
    public class DashboardViewModel : BaseViewModel 
    {
        public List<Pedido> Pedidos { get; set; }
        public uint PedidoAprovados { get; set; }
        public uint PedidoReprovados { get; set; }
        public uint PedidoPendentes { get; set; }
        public DashboardViewModel()
        {
            this.Pedidos = new List<Pedido>();
        }
    }
}