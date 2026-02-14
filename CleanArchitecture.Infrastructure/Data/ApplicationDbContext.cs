using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Define DbSet properties for your entities here
        // public DbSet<YourEntity> YourEntities { get; set; }

        public DbSet<Almacen> Almacen { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Existencia> Existencia { get; set; }
        public DbSet<MovimientoInventario> MovimientoInventario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}