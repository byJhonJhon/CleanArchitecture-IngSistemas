using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class MovimientoInventarioRepository : RepositoryBase<MovimientoInventario>, IMovimientoInventarioRepository
    {
        public MovimientoInventarioRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
