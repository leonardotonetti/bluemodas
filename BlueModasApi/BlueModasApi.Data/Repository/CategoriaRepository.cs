using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Business.Models;
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Repository
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        private readonly DbSet<Categoria> _dbSet;

        public CategoriaRepository(BlueModasApiContext context) : base(context)
        {
            _dbSet = context.Set<Categoria>();
        }
    }
}
