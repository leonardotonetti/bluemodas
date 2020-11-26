using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Dto;

namespace BlueModasApi.Business.Interfaces.Business.Service
{
    public interface ITipoPublicoAlvoService
    {
        Task<IEnumerable<TipoPublicoAlvoDto>> Get();
    }
}
