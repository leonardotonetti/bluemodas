﻿using BlueModasApi.Business.Interfaces.Data.Repository;
using BlueModasApi.Business.Models;
using BlueModasApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Data.Repository
{
    public class PedidoItemRepository : GenericRepository<PedidoItem>, IPedidoItemRepository
    {
        private readonly DbSet<PedidoItem> _dbSet;

        public PedidoItemRepository(BlueModasApiContext context) : base(context)
        {
            _dbSet = context.Set<PedidoItem>();
        }
    }
}
