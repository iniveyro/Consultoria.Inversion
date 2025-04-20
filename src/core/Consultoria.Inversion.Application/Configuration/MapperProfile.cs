using AutoMapper;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;
using Consultoria.Inversion.Application.Database.User.Queries.GetAllUsers;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserById;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserByEmailAndPass;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserModel, CreateUserModel>().ReverseMap();
            CreateMap<UserModel, UpdateUserModel>().ReverseMap();
            CreateMap<UserModel, GetAllUsersModel>().ReverseMap();
            CreateMap<UserModel, GetUserByIdModel>().ReverseMap();
            CreateMap<UserModel, GetUserByEmailAndPassModel>().ReverseMap();
        }
    }
}