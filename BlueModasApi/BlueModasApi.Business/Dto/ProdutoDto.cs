namespace BlueModasApi.Business.Dto
{
    public class ProdutoDto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string UrlImagem { get; set; }
        public decimal ValorUnitario { get; set; }

        public TipoPublicoAlvoCategoriaDto TipoPublicoAlvoCategoria { get; set; }
    }
}
