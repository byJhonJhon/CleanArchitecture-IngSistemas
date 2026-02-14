using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Presentation
{
    public static class ConfigurationServices
    {
        public static void AddConfigurationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
