using System.Threading.Tasks;
using BlueModasApi.Business.Dto;

namespace BlueModasApi.Business.Interfaces.Business.Service
{
    public interface IClienteService
    {
        Task<ClienteDto> Get(string nome, string sobreNome);
    }
}
