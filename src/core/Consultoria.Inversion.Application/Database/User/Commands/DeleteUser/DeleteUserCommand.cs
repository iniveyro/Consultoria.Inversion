using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.User.Commands.DeleteUser
{
    public class DeleteUserCommand : IDeleteUserCommand
    {
        private readonly IDatabaseService _databaseService;
        
        public DeleteUserCommand(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<bool> Execute (int UserId)
        {
            var user = await _databaseService.User.FirstOrDefaultAsync(x=>x.UserId == UserId);
            if (user == null)
            {
                return false;
            }
            _databaseService.User.Remove(user);
            return await _databaseService.SaveAsync();
        }
    }
}