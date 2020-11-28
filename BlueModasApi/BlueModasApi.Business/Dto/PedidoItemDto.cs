using System.ComponentModel.DataAnnotations;

namespace BlueModasApi.Business.Dto
{
    public class PedidoItemDto
    {
        public int PedidoItemId { get; set; }
        public int PedidoId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Informe um Id de produto válido")]
        public int ProdutoId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Informe uma quantidade válida")]
        public int Quantidade { get; set; }

        public ProdutoDto Produto { get; set; }
    }
}
