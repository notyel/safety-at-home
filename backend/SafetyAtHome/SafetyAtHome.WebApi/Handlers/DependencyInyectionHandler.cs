using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SafetyAtHome.Business.Interfaces.Auth;
using SafetyAtHome.Business.Services.Auth;
using SafetyAtHome.Common.Mapping.MappingProfiles;
using SafetyAtHome.Data;
using SafetyAtHome.Data.Repositories.Auth;
using SafetyAtHome.Domain.Repositories.Auth;

namespace SafetyAtHome.WebApi.Handlers
{
    public static class DependencyInyectionHandler
    {
        public static IServiceCollection DependencyInyectionConfig(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuración de la base de datos
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Configuración de AutoMapper
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            // Dependencias 
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
