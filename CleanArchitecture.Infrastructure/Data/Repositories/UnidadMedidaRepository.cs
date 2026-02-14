using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class UnidadMedidaRepository : RepositoryBase<UnidadMedida>, IUnidadMedidaRepository
    {
        public UnidadMedidaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
