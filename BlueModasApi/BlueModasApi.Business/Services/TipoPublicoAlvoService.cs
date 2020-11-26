using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BlueModasApi.Business.Dto;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Services
{
    public class TipoPublicoAlvoService : ITipoPublicoAlvoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoPublicoAlvoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TipoPublicoAlvoDto>> Get()
        {
            var tipoPublicoAlvoDb = await _unitOfWork.TipoPublicoAlvoRepository.GetAll();
            var tipoPublicoAlvoDto = _mapper.Map<IEnumerable<TipoPublicoAlvo>, IEnumerable<TipoPublicoAlvoDto>>(tipoPublicoAlvoDb);

            foreach (var item in tipoPublicoAlvoDto)
            {
                var tipoPublicoAlvoCategoriaDb = await _unitOfWork.TipoPublicoAlvoCategoriaRepository.GetByTipoPublicoAlvo(item.TipoPublicoAlvoId);
                var tipoPublicoAlvoCategoriaDto = _mapper.Map<IEnumerable<TipoPublicoAlvoCategoria>, IEnumerable<TipoPublicoAlvoCategoriaDto>>(tipoPublicoAlvoCategoriaDb);

                item.TipoPublicoAlvoCategoria = tipoPublicoAlvoCategoriaDto;
            }

            return tipoPublicoAlvoDto;
        }
    }
}
