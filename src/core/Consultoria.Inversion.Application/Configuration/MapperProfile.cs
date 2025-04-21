using AutoMapper;
using Consultoria.Inversion.Domain.Models;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;
using Consultoria.Inversion.Application.Database.User.Queries.GetAllUsers;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserById;
using Consultoria.Inversion.Application.Database.User.Queries.GetUserByEmailAndPass;
using Consultoria.Inversion.Application.Database.Asesor.Commands.CreateAsesor;
using Consultoria.Inversion.Application.Database.Asesor.Queries.GetAsesorById;

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
            #region Asesor
            CreateMap<AsesorModel, CreateAsesorModel>().ReverseMap();
            CreateMap<AsesorModel, UpdateUserModel>().ReverseMap();
            CreateMap<AsesorModel, GetAllUsersModel>().ReverseMap();
            CreateMap<AsesorModel, GetAsesorByIdModel>().ReverseMap();
            #endregion
        }
    }
}