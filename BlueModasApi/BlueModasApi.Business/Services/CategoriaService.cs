using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoriaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Categoria>> Get()
        {
            return await _unitOfWork.CategoriaRepository.GetAll();
        }
    }
}
