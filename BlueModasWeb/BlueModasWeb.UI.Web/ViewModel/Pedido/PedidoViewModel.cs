using System.Collections.Generic;
using System.Linq;

namespace BlueModasWeb.UI.Web.ViewModel.Pedido
{
    public class PedidoViewModel
    {
        public int PedidoCodigo { get; set; }

        public decimal ValorTotal => PedidoItens?.Sum(x => x.Quantidade * (x.Produto?.ValorUnitario ?? 0)) ?? 0;

        public ClienteViewModel Cliente { get; set; }

        public IEnumerable<PedidoItemViewModel> PedidoItens { get; set; }
    }
}
