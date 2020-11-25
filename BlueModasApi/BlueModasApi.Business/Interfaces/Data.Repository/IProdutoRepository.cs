using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Interfaces.Data.Repository
{
    public interface IProdutoRepository : IGenericRepository<Produto>
    {
        Task<IEnumerable<Produto>> Get(int? idTipoPublicoAlvo, int? idCategoria);
    }
}
