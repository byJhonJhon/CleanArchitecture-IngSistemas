using CleanArchitecture.Application.Interface;
using CleanArchitecture.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class ConfigurationServices
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IAlmacenRepository, AlmacenRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IExistenciaRepository, ExistenciaRepository>();
            services.AddScoped<IUnidadMedidaRepository, UnidadMedidaRepository>();
            services.AddScoped<IMovimientoInventarioRepository, MovimientoInventarioRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<IProveedorRepository, ProveedorRepository>();
        }
    }
}