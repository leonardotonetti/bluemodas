using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Business.Models;
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Repository
{
    public class TipoPublicoAlvoCategoriaRepository : GenericRepository<TipoPublicoAlvoCategoria>, ITipoPublicoAlvoCategoriaRepository
    {
        private readonly DbSet<TipoPublicoAlvoCategoria> _dbSet;

        public TipoPublicoAlvoCategoriaRepository(BlueModasApiContext context) : base(context)
        {
            _dbSet = context.Set<TipoPublicoAlvoCategoria>();
        }

        public async Task<IEnumerable<TipoPublicoAlvoCategoria>> GetByTipoPublicoAlvo(int idTipoPublicoAlvo)
        {
            return await _dbSet
                .Include(t => t.Categoria)
                .Where(t => t.TipoPublicoAlvoId == idTipoPublicoAlvo)
                .ToListAsync();
        }
    }
}
