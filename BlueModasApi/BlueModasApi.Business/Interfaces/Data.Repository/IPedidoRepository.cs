using System.Threading.Tasks;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Interfaces.Data.Repository
{
    public interface IPedidoRepository : IGenericRepository<Pedido>
    {
        Task<Pedido> Get(int idPedido);
    }
}
