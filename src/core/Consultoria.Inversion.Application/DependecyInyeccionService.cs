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
using Consultoria.Inversion.Application.Database.Broker.Commands.CreateBroker;
using Consultoria.Inversion.Application.Database.Broker.Commands.UpdateBroker;
using Consultoria.Inversion.Application.Database.Broker.Commands.DeleteBroker;
using Consultoria.Inversion.Application.Database.Broker.Queries.GetAllBroker;
using Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerById;
using Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerByDNI;
using Consultoria.Inversion.Application.Database.Inversion.Commands.CreateInversion;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetAllInversiones;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByDNI;
using Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByTipo;
using FluentValidation;
using Consultoria.Inversion.Application.Validators.User;
using Consultoria.Inversion.Application.Validators.Broker;
using Consultoria.Inversion.Application.Validators.Inversion;

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
            #region BrokerServices
            services.AddTransient<ICreateBrokerCommand, CreateBrokerCommand>();
            services.AddTransient<IUpdateBrokerCommand, UpdateBrokerCommand>();
            services.AddTransient<IDeleteBrokerCommand, DeleteBrokerCommand>();
            services.AddTransient<IGetAllBrokersQuery, GetAllBrokersQuery>();
            services.AddTransient<IGetBrokerByIdQuery, GetBrokerByIdQuery>();
            services.AddTransient<IGetBrokerByDNIQuery, GetBrokerByDNIQuery>();
            #endregion
            #region Inversiones
            services.AddTransient<ICreateInversionCommand, CreateInversionCommand>();
            services.AddTransient<IGetAllInversionesQuery, GetAllInversionesQuery>();
            services.AddTransient<ICreateInversionCommand, CreateInversionCommand>();
            services.AddTransient<IGetInversionByDNIQuery, GetInversionByDNIQuery>();
            services.AddTransient<IGetInversionByTipoQuery, GetInversionByTipoQuery>();
            #endregion
            #region Validator
                services.AddScoped<IValidator<CreateUserModel>, CreateUserValidator>();
                services.AddScoped<IValidator<UpdateUserModel>, UpdateUserValidator>();
                services.AddScoped<IValidator<UpdateUserPasswordModel>, UpdateUserPasswordValidator>();
                services.AddScoped<IValidator<(string,string)>, GetUserByEmailPasswordValidator>();
                services.AddScoped<IValidator<CreateBrokerModel>, CreateBrokerValidator>();
                services.AddScoped<IValidator<UpdateBrokerModel>, UpdateBrokerValidator>();
                services.AddScoped<IValidator<CreateInversionModel>, CreateInversionValidator>();
            #endregion
            return services;
        }
    }
}