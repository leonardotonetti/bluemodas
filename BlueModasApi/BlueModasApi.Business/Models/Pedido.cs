using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        [Required]
        public int PedidoCodigo { get; set; }
        [Required]
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
