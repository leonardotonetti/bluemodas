using System;

namespace BlueModasApi.Business.Interfaces.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
