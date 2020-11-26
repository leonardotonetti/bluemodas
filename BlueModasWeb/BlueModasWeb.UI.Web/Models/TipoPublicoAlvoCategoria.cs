namespace BlueModasWeb.UI.Web.Models
{
    public class TipoPublicoAlvoCategoria
    {
        public int TipoPublicoAlvoCategoriaId { get; set; }
        public int TipoPublicoAlvoId { get; set; }
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
