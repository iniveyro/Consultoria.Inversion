using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Consultoria.Inversion.Common
{
    public static class DependecyInyeccionService
    {
        public static IServiceCollection AddCommon(this IServiceCollection services)
        {
            return services;
        }
    }
}