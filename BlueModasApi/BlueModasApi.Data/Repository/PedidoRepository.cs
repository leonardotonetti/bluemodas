using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Business.Models;
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Repository
{
    public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
    {
        private readonly DbSet<Pedido> _dbSet;

        public PedidoRepository(BlueModasApiContext context) : base(context)
        {
            _dbSet = context.Set<Pedido>();
        }
    }
}
