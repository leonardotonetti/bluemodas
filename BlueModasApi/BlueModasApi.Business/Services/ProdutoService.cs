using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BlueModasApi.Business.Dto;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProdutoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoDto>> Get(int? idTipoPublicoAlvo, int? idCategoria)
        {
            var produtoDb = await _unitOfWork.ProdutoRepository.Get(idTipoPublicoAlvo, idCategoria);
            var produtoDto = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoDto>>(produtoDb);

            return produtoDto;
        }
    }
}
