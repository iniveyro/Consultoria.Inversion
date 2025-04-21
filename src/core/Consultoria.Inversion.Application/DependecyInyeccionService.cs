using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Consultoria.Inversion.Application.Configuration;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;
using Consultoria.Inversion.Application.Database.User.Commands.DeleteUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUserPassword;
using Consultoria.Inversion.Application.Database.User.Queries.GetAllUsers;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserById;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserByEmailAndPass;
using Consultoria.Inversion.Application.Database.Asesor.Commands.CreateAsesor;
using Consultoria.Inversion.Application.Database.Asesor.Commands.UpdateAsesor;
using Consultoria.Inversion.Application.Database.Asesor.Commands.DeleteAsesor;
using Consultoria.Inversion.Application.Database.Asesor.Queries.GetAllAsesores;
using Consultoria.Inversion.Application.Database.Asesor.Queries.GetAsesorById;
using Consultoria.Inversion.Application.Database.Asesor.Queries.GetAsesorByDNI;
using Consultoria.Inversion.Application.Database.Inversion.Commands.CreateInversion;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetAllInversiones;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByDNI;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByTipo;

namespace Consultoria.Inversion.Application
{
    public static class DependecyInyeccionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config => {config.AddProfile(new MapperProfile());});
            services.AddSingleton(mapper.CreateMapper());
            #region UserServices
            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
            services.AddTransient<IDeleteUserCommand,DeleteUserCommand>();
            services.AddTransient<IUpdateUserPasswordCommand, UpdateUserPasswordCommand>();
            services.AddTransient<IGetAllUsersQuery, GetAllUsersQuery>();
            services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
            services.AddTransient<IGetUserByEmailAndPassQuery, GetUserByEmailAndPassQuery>();
            #endregion
            #region AsesorServices
            services.AddTransient<ICreateAsesorCommand, CreateAsesorCommand>();
            services.AddTransient<IUpdateAsesorCommand, UpdateAsesorCommand>();
            services.AddTransient<IDeleteAsesorCommand, DeleteAsesorCommand>();
            services.AddTransient<IGetAllAsesoresQuery, GetAllAsesoresQuery>();
            services.AddTransient<IGetAsesorByIdQuery, GetAsesorByIdQuery>();
            services.AddTransient<IGetAsesorByDNIQuery, GetAsesorByDNIQuery>();
            #endregion
            #region Inversiones
            services.AddTransient<ICreateInversionCommand, CreateInversionCommand>();
            services.AddTransient<IGetAllInversionesQuery, GetAllInversionesQuery>();
            services.AddTransient<ICreateInversionCommand, CreateInversionCommand>();
            services.AddTransient<IGetInversionByDNIQuery, GetInversionByDNIQuery>();
            services.AddTransient<IGetInversionByTipoQuery, GetInversionByTipoQuery>();
            #endregion
            return services;
        }
    }
}