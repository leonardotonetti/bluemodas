using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Business.Models;
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Repository
{
    public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
    {
        private readonly DbSet<Produto> _dbSet;

        public ProdutoRepository(BlueModasApiContext context) : base(context)
        {
            _dbSet = context.Set<Produto>();
        }

        public async Task<IEnumerable<Produto>> Get(int? idTipoPublicoAlvo, int? idCategoria)
        {
            return await _dbSet
                .Include(p => p.TipoPublicoAlvoCategoria)
                .Where(t =>
                    (t.TipoPublicoAlvoCategoria.TipoPublicoAlvoId == idTipoPublicoAlvo || !idTipoPublicoAlvo.HasValue) &&
                    (t.TipoPublicoAlvoCategoria.CategoriaId == idCategoria || !idCategoria.HasValue)
                )
                .ToListAsync();
        }
    }
}
