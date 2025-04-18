using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.User.Commands.UpdateUserPassword
{
    public class UpdateUserPasswordCommand : IUpdateUserPasswordCommand
    {
        private readonly IDatabaseService _databaseService;

        public UpdateUserPasswordCommand(IDatabaseService databaseService)
        {
            _databaseService=databaseService;
        }

        public async Task<bool> Execute (UpdateUserPasswordModel model)
        {
            var user = await _databaseService.User.FirstOrDefaultAsync(x=>x.UserId == model.UserId);
            if (user == null)
                return false;

            model.Password=user.Password;
            //_databaseService.User.Update(user);
            return await _databaseService.SaveAsync();

        }

    }
}