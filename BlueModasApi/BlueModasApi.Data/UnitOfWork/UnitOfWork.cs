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
        private ITipoPublicoAlvoCategoriaRepository _tipoPublicoAlvoCategoriaRepository;
        private IClienteRepository _clienteRepository;
        private IPedidoRepository _pedidoRepository;
        private IPedidoItemRepository _pedidoItemRepository;

        public UnitOfWork(BlueModasApiContext dbContext)
        {
            _dbContext = dbContext;
        }

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

        public ITipoPublicoAlvoCategoriaRepository TipoPublicoAlvoCategoriaRepository
        {
            get
            {
                if (_tipoPublicoAlvoCategoriaRepository == null)
                    _tipoPublicoAlvoCategoriaRepository = new TipoPublicoAlvoCategoriaRepository(_dbContext);
                return _tipoPublicoAlvoCategoriaRepository;
            }
        }

        public IClienteRepository ClienteRepository
        {
            get
            {
                if (_clienteRepository == null)
                    _clienteRepository = new ClienteRepository(_dbContext);
                return _clienteRepository;
            }
        }

        public IPedidoRepository PedidoRepository
        {
            get
            {
                if (_pedidoRepository == null)
                    _pedidoRepository = new PedidoRepository(_dbContext);
                return _pedidoRepository;
            }
        }

        public IPedidoItemRepository PedidoItemRepository
        {
            get
            {
                if (_pedidoItemRepository == null)
                    _pedidoItemRepository = new PedidoItemRepository(_dbContext);
                return _pedidoItemRepository;
            }
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
