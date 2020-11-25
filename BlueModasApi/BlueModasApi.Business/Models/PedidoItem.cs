using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Models
{
    public class PedidoItem
    {
        public int PedidoItemId { get; set; }
        [Required]
        public int PedidoId { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        [Required]
        public int Quantidade { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}
