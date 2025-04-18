using AutoMapper;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Database.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IUpdateUserCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly Mapper _mapper;

        public UpdateUserCommand(IDatabaseService databaseService, Mapper mapper)
        {
            _databaseService=databaseService;
            _mapper=mapper;
        }

        public async Task<UpdateUserModel> Execute (UpdateUserModel model)
        {
            var user = _mapper.Map<UserModel>(model);
            _databaseService.User.Update(user);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}