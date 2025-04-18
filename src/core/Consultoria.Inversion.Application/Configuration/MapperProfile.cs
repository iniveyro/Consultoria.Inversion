using AutoMapper;
using Consultoria.Inversion.Application.Database.User.Commands;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserModel, CreateUserModel>().ReverseMap();
        }
    }
}