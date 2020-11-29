using System.Threading.Tasks;
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

        public async Task<Cliente> Get(string nome, string sobrenome)
        {
            return await _dbSet
                .FirstOrDefaultAsync(c =>
                    c.Nome.Equals(nome) &&
                    c.SobreNome.Equals(sobrenome)
                );
        }
    }
}
