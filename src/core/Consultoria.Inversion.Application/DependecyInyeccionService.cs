using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Consultoria.Inversion.Application.Configuration;

namespace Consultoria.Inversion.Application
{
    public static class DependecyInyeccionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config => {config.AddProfile(new MapperProfile());});
            services.AddSingleton(mapper.CreateMapper());
            return services;
        }
    }
}