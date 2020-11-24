using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(500)]
        [Required]
        public string UrlImagem { get; set; }
        [Required]
        public int TipoPublicoAlvoCategoriaId { get; set; }

        public TipoPublicoAlvoCategoria TipoPublicoAlvoCategoria { get; set; }
    }
}
