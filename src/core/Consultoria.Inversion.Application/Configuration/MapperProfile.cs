using AutoMapper;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserModel, CreateUserModel>().ReverseMap();
            CreateMap<UserModel, UpdateUserModel>().ReverseMap();
        }
    }
}