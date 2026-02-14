using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class AlmacenRepository : RepositoryBase<Almacen>, IAlmacenRepository
    {
        public AlmacenRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
