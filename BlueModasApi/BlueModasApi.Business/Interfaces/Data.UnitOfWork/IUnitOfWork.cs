using System;
using BlueModasApi.Business.Interfaces.Data.Repository;

namespace BlueModasApi.Business.Interfaces.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITipoPublicoAlvoRepository TipoPublicoAlvoRepository { get; }
        ICategoriaRepository CategoriaRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        void Save();
    }
}
