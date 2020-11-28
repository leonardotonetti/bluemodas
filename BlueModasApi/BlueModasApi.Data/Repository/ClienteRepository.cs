using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Business.Models;
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Repository
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly DbSet<Cliente> _dbSet;

        public ClienteRepository(BlueModasApiContext context) : base(context)
        {
            _dbSet = context.Set<Cliente>();
        }
    }
}
