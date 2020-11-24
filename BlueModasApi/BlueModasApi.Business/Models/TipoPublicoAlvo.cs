using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Models
{
    public class TipoPublicoAlvo
    {
        public int TipoPublicoAlvoId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }
    }
}
