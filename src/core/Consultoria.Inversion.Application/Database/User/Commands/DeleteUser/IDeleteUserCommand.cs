namespace Consultoria.Inversion.Application.Database.User.Commands.DeleteUser
{
    public interface IDeleteUserCommand
    {
        Task<bool> Execute (int UserId);
    }
}