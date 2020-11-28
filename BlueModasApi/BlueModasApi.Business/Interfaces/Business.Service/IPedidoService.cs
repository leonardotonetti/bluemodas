using System.Threading.Tasks;
using BlueModasApi.Business.Dto;

namespace BlueModasApi.Business.Interfaces.Business.Service
{
    public interface IPedidoService
    {
        Task<PedidoDto> Post(PedidoDto pedidoDto);
    }
}
