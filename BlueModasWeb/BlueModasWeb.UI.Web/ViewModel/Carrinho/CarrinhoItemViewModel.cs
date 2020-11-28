namespace BlueModasWeb.UI.Web.ViewModel.Carrinho
{
    public class CarrinhoItemViewModel
    {
        public decimal QuantidadeItem { get; set; } = 1;

        public ProdutoViewModel Produto { get; set; }
    }
}
