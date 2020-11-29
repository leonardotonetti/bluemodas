using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BlueModasApiContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(BlueModasApiContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            var insertedEntity = await _dbSet.AddAsync(entity);
            return insertedEntity.Entity;
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
