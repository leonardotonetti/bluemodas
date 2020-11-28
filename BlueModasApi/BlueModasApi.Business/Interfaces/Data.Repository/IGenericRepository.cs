using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueModasApi.Business.Interfaces.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(object id);
        Task<IEnumerable<T>> GetAll();
        Task<T> InsertAsync(T entidade);
        void Update(T entidade);
        void Delete(object id);
    }
}
