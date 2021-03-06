﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BlueModasApi.Business.Models;

namespace BlueModasApi.Business.Interfaces.Business.Service
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> Get();
    }
}
