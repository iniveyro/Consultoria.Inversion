using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultoria.Inversion.Api
{
    public static class DependecyInyeccionService
    {
        public static IServiceCollection AddWebApi(this IServiceCollection services)
        {
            return services;
        }
    }
}