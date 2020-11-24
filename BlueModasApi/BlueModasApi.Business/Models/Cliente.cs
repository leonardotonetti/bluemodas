using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(100)]
        [Required]
        public string SobreNome { get; set; }
        [MaxLength(100)]
        [Required]
        public string Email { get; set; }
        [MaxLength(11)]
        [Required]
        public string Telefone { get; set; }
    }
}
