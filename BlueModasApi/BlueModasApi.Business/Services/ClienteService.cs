using System.Threading.Tasks;
using AutoMapper;
using BlueModasApi.Business.Dto;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClienteService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ClienteDto> Get(string nome, string sobreNome)
        {
            var clienteDb = await _unitOfWork.ClienteRepository.Get(nome, sobreNome);
            var clienteDto = _mapper.Map<Cliente, ClienteDto>(clienteDb);

            return clienteDto;
        }
    }
}
