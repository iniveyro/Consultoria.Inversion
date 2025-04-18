using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Consultoria.Inversion.Application.Configuration;
using Consultoria.Inversion.Application.Database.User.Commands;

namespace Consultoria.Inversion.Application
{
    public static class DependecyInyeccionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config => {config.AddProfile(new MapperProfile());});
            services.AddSingleton(mapper.CreateMapper());
            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            return services;
        }
    }
}