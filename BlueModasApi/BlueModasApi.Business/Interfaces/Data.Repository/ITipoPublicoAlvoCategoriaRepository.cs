using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Interfaces.Data.Repository
{
    public interface ITipoPublicoAlvoCategoriaRepository : IGenericRepository<TipoPublicoAlvoCategoria>
    {
        Task<IEnumerable<TipoPublicoAlvoCategoria>> GetByTipoPublicoAlvo(int idTipoPublicoAlvo);
    }
}
