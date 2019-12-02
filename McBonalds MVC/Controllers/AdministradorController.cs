using McBonalds_MVC.Enums;
using McBonalds_MVC.Repositories;
using McBonalds_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers {
    public class AdministradorController : AbstractController {
        PedidoRepository pedidoRepository = new PedidoRepository ();
        [HttpGet]
        public IActionResult Dashboard () {
            var tiposUsuario = uint.Parse(ObterUsuarioTipoSession ());
            if (tiposUsuario.Equals ((uint) TiposUsuario.ADMINISTRADOR)) {
                var pedidos = pedidoRepository.ObterTodos ();

                DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                foreach (var pedido in pedidos) {
                    switch (pedido.Status) {
                        case (uint) StatusPedido.REPROVADO:
                            dashboardViewModel.PedidoReprovados++;
                            break;

                        case (uint) StatusPedido.APROVADO:
                            dashboardViewModel.PedidoAprovados++;
                            break;

                        default:
                            dashboardViewModel.PedidoPendentes++;
                            dashboardViewModel.Pedidos.Add (pedido);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                return View (dashboardViewModel);
            }
            return View ("Erro", new RespostaViewModel () {
                NomeView = "Dashboard",
                    Mensagem = "Você não pode acessar"
            });
        }
    }
}