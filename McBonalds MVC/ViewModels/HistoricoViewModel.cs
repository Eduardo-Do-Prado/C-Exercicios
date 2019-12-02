using System.Collections.Generic;
using McBonalds_MVC.Models;

namespace McBonalds_MVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Pedido> Pedidos {get;set;}
    }
}