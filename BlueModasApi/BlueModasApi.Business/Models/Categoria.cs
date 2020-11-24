using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }
    }
}
