using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Business.Models;
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Repository
{
    public class TipoPublicoAlvoRepository : GenericRepository<TipoPublicoAlvo>, ITipoPublicoAlvoRepository
    {
        private readonly DbSet<TipoPublicoAlvo> _dbSet;

        public TipoPublicoAlvoRepository(BlueModasApiContext context) : base(context)
        {
            _dbSet = context.Set<TipoPublicoAlvo>();
        }
    }
}
