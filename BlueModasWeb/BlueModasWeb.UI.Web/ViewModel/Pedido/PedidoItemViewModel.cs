namespace BlueModasWeb.UI.Web.ViewModel.Pedido
{
    public class PedidoItemViewModel
    {
        public int PedidoItemId { get; set; }
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public ProdutoViewModel Produto { get; set; }
    }
}
