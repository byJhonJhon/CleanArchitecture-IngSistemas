using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class ExistenciaRepository : RepositoryBase<Existencia>, IExistenciaRepository
    {
        public ExistenciaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}