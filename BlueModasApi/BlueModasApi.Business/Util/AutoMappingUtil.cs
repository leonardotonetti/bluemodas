using AutoMapper;
using BlueModasApi.Business.Dto;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Util
{
    public class AutoMappingUtil : Profile
    {
        public AutoMappingUtil()
        {

            CreateMap<TipoPublicoAlvo, TipoPublicoAlvoDto>();

            CreateMap<Categoria, CategoriaDto>();

            CreateMap<TipoPublicoAlvoCategoria, TipoPublicoAlvoCategoriaDto>();

            CreateMap<Produto, ProdutoDto>();

            CreateMap<ClienteDto, Cliente>();
            CreateMap<Cliente, ClienteDto>();

            CreateMap<PedidoDto, Pedido>();
            CreateMap<Pedido, PedidoDto>();

            CreateMap<PedidoItemDto, PedidoItem>();
            CreateMap<PedidoItem, PedidoItemDto>();
        }
    }
}
