using System;
using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Business.Interfaces.Data.UnitOfWork;
using BlueModasApi.Data.Context;
using BlueModasApi.Data.Repository;

namespace BlueModasApi.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlueModasApiContext _dbContext;

        private ITipoPublicoAlvoRepository _tipoPublicoAlvoRepository;
        private ICategoriaRepository _categoriaRepository;
        private IProdutoRepository _produtoRepository;

        public ITipoPublicoAlvoRepository TipoPublicoAlvoRepository
        {
            get
            {
                if (_tipoPublicoAlvoRepository == null)
                    _tipoPublicoAlvoRepository = new TipoPublicoAlvoRepository(_dbContext);
                return _tipoPublicoAlvoRepository;
            }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                if (_categoriaRepository == null)
                    _categoriaRepository = new CategoriaRepository(_dbContext);
                return _categoriaRepository;
            }
        }

        public IProdutoRepository ProdutoRepository
        {
            get
            {
                if (_produtoRepository == null)
                    _produtoRepository = new ProdutoRepository(_dbContext);
                return _produtoRepository;
            }
        }

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
