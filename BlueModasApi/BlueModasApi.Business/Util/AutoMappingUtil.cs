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
        }
    }
}
