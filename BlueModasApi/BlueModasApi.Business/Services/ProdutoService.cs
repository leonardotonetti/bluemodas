using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProdutoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Produto>> Get(int? idTipoPublicoAlvo, int? idCategoria)
        {
            return await _unitOfWork.ProdutoRepository.Get(idTipoPublicoAlvo, idCategoria);
        }
    }
}
