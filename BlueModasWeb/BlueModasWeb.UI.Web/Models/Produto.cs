namespace BlueModasWeb.UI.Web.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string UrlImagem { get; set; }
        public decimal ValorUnitario { get; set; }

        public TipoPublicoAlvoCategoria TipoPublicoAlvoCategoria { get; set; }
    }
}
