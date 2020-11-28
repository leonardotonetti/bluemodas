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

            var clienteInserido = await _unitOfWork.ClienteRepository.InsertAsync(pedido.Cliente);

            pedido.ClienteId = clienteInserido.ClienteId;
            var pedidoInserido = await _unitOfWork.PedidoRepository.InsertAsync(pedido);

            foreach (var item in pedidoInserido.PedidoItens)
            {
                item.PedidoId = pedidoInserido.PedidoId;
                await _unitOfWork.PedidoItemRepository.InsertAsync(item);
            }

            _unitOfWork.Save();

            var pedidoDb = await _unitOfWork.PedidoRepository.Get(pedidoInserido.PedidoId);
            var pedidoInseridoDto = _mapper.Map<Pedido, PedidoDto>(pedidoDb);

            return pedidoInseridoDto;
        }
    }
}
