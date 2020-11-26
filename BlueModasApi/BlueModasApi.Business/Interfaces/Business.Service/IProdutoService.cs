using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Dto;

namespace BlueModasApi.Business.Interfaces.Business.Service
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDto>> Get(int? idTipoPublicoAlvo, int? idCategoria);
    }
}
