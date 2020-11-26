namespace BlueModasApi.Business.Dto
{
    public class TipoPublicoAlvoCategoriaDto
    {
        public int TipoPublicoAlvoCategoriaId { get; set; }
        public int TipoPublicoAlvoId { get; set; }
        public int CategoriaId { get; set; }

        public CategoriaDto Categoria { get; set; }
    }
}
