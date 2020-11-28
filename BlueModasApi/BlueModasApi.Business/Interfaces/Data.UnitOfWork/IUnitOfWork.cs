using System;
using BlueModasApi.Business.Interfaces.Data.Repository;

namespace BlueModasApi.Business.Interfaces.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITipoPublicoAlvoRepository TipoPublicoAlvoRepository { get; }
        ICategoriaRepository CategoriaRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        ITipoPublicoAlvoCategoriaRepository TipoPublicoAlvoCategoriaRepository { get; }
        IClienteRepository ClienteRepository { get; }
        IPedidoRepository PedidoRepository { get; }
        IPedidoItemRepository PedidoItemRepository { get; }
        void Save();
    }
}
