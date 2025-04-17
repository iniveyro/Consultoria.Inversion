using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Consultoria.Inversion.External
{
    public static class DependecyInyeccionService
    {
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}