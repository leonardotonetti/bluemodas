using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Models
{
    public class TipoPublicoAlvoCategoria
    {
        public int TipoPublicoAlvoCategoriaId { get; set; }
        [Required]
        public int TipoPublicoAlvoId { get; set; }
        [Required]
        public int CategoriaId { get; set; }

        public TipoPublicoAlvo TipoPublicoAlvo { get; set; }
        public Categoria Categoria { get; set; }
    }
}
