using Microsoft.EntityFrameworkCore;
using SafetyAtHome.Data;

namespace SafetyAtHome.WebApi.Handlers
{
    public static class DependencyInyectionHandler
    {
        public static IServiceCollection DependencyInyectionConfig(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuración de la base de datos
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
