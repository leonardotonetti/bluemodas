using System.Collections.Generic;

namespace BlueModasApi.Business.Dto
{
    public class PedidoDto
    {
        public int PedidoCodigo { get; set; }
        public ClienteDto Cliente { get; set; }

        public IEnumerable<PedidoItemDto> PedidoItens { get; set; }
    }
}
