using System.Threading.Tasks;
using AutoMapper;
using BlueModasApi.Business.Dto;
using BlueModasApi.Business.Interfaces.Business.Service;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PedidoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PedidoDto> Post(PedidoDto pedidoDto)
        {
            var pedido = _mapper.Map<PedidoDto, Pedido>(pedidoDto);

            var cliente = await _unitOfWork.ClienteRepository.Get(pedido.Cliente.Nome, pedido.Cliente.SobreNome);
            if (cliente != null)
            {
                pedido.ClienteId = cliente.ClienteId;

                cliente.Email = pedidoDto.Cliente.Email;
                cliente.Telefone = pedidoDto.Cliente.Telefone;
                _unitOfWork.ClienteRepository.Update(cliente);

                pedido.Cliente = null;
            }

            var pedidoInserido = await _unitOfWork.PedidoRepository.InsertAsync(pedido);

            _unitOfWork.Save();

            var pedidoDb = await _unitOfWork.PedidoRepository.Get(pedidoInserido.PedidoId);
            var pedidoInseridoDto = _mapper.Map<Pedido, PedidoDto>(pedidoDb);

            return pedidoInseridoDto;
        }
    }
}
