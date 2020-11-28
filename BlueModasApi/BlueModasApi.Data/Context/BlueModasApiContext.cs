using BlueModasApi.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Context
{
    public class BlueModasApiContext : DbContext
    {
        public BlueModasApiContext(DbContextOptions<BlueModasApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("PedidoCodigo")
                .StartsAt(1)
                .IncrementsBy(1);

            modelBuilder.Entity<Pedido>()
                .Property(o => o.PedidoCodigo)
                .HasDefaultValueSql("NEXT VALUE FOR PedidoCodigo");
        }

        public DbSet<TipoPublicoAlvo> TipoPublicoAlvo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<TipoPublicoAlvoCategoria> TipoPublicoAlvoCategoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
    }
}
