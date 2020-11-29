using System.Threading.Tasks;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Interfaces.Data.Repository
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        Task<Cliente> Get(string nome, string sobrenome);
    }
}
