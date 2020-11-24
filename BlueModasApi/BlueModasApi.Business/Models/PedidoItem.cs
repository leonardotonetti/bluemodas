using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueModasApi.Business.Models
{
    public class PedidoItem
    {
        public int PedidoItemId { get; set; }
        [Required]
        public int PedidoId { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        [Column(TypeName = "decimal(15,4)")]
        [Required]
        public decimal Quantidade { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}
