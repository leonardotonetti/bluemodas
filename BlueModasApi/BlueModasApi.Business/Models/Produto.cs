using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(15,2)")]
        [Required]
        public decimal ValorUnitario { get; set; }
        [Required]
        public int TipoPublicoAlvoCategoriaId { get; set; }

        public TipoPublicoAlvoCategoria TipoPublicoAlvoCategoria { get; set; }
    }
}
