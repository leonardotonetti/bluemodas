using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Services
{
    public class TipoPublicoAlvoService : ITipoPublicoAlvoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TipoPublicoAlvoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TipoPublicoAlvo>> Get()
        {
            return await _unitOfWork.TipoPublicoAlvoRepository.GetAll();
        }
    }
}
