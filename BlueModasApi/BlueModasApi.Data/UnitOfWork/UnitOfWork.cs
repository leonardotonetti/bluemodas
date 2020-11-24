using System;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Data.Context;

namespace BlueModasApi.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlueModasApiContext _dbContext;

        public UnitOfWork(BlueModasApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
