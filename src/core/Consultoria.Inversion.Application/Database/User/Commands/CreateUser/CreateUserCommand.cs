using AutoMapper;
using static System.Console;
using Consultoria.Inversion.Domain.Models;
using Consultoria.Inversion.Domain.Enums;

namespace Consultoria.Inversion.Application.Database.User.Commands.CreateUser
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public CreateUserCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService=databaseService;
            _mapper=mapper;            
        }
    
        public async Task<CreateUserModel> Execute(CreateUserModel model)
        {
            var user = _mapper.Map<UserModel>(model);
            user.FechaRegistro = DateOnly.FromDateTime(DateTime.Now);
            await _databaseService.User.AddAsync(user);
            await _databaseService.SaveAsync();
            return model;
        }
    
    }
}