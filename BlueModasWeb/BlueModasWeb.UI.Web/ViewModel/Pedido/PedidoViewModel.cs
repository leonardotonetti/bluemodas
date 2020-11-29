using System.Collections.Generic;

namespace BlueModasWeb.UI.Web.ViewModel.Pedido
{
    public class PedidoViewModel
    {
        public int PedidoCodigo { get; set; }
        public ClienteViewModel Cliente { get; set; }

        public IEnumerable<PedidoItemViewModel> PedidoItens { get; set; }
    }
}
