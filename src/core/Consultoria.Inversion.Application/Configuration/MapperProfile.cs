using AutoMapper;
using Consultoria.Inversion.Domain.Models;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;
using Consultoria.Inversion.Application.Database.User.Queries.GetAllUsers;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserById;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserByEmailAndPass;
using Consultoria.Inversion.Application.Database.Broker.Commands.UpdateBroker;
using Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerById;
using Consultoria.Inversion.Application.Database.Inversion.Commands.CreateInversion;
using Consultoria.Inversion.Application.Database.Broker.Commands.CreateBroker;
using Consultoria.Inversion.Application.Database.Broker.Queries.GetAllBroker;

namespace Consultoria.Inversion.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region  User
            CreateMap<UserModel, CreateUserModel>().ReverseMap();
            CreateMap<UserModel, UpdateUserModel>().ReverseMap();
            CreateMap<UserModel, GetAllUsersModel>().ReverseMap();
            CreateMap<UserModel, GetUserByIdModel>().ReverseMap();
            CreateMap<UserModel, GetUserByEmailAndPassModel>().ReverseMap();
            #endregion
            #region Broker
            CreateMap<BrokerModel, CreateBrokerModel>().ReverseMap();
            CreateMap<BrokerModel, UpdateBrokerModel>().ReverseMap();
            CreateMap<BrokerModel, GetAllBrokersModel>().ReverseMap();
            CreateMap<BrokerModel, GetBrokerByIdModel>().ReverseMap();
            #endregion
            #region Inversiones
            CreateMap<InversionModel, CreateInversionModel>().ReverseMap();
            #endregion
        }
    }
}