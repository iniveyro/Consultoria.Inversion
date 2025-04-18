using AutoMapper;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Database.User.Commands
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
            await _databaseService.User.AddAsync(user);
            await _databaseService.SaveAsync();
            return model;
        }
    
    }
}