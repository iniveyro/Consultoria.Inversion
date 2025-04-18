using Consultoria.Inversion.Application.Database;
using Consultoria.Inversion.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Consultoria.Inversion.Persistence
{
    public static class DependecyInyeccionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseService>(options => 
                options.UseSqlServer(configuration["SQLConnection"])
            );
            services.AddScoped<IDatabaseService,DatabaseService>();
            return services;
        }
    }
}