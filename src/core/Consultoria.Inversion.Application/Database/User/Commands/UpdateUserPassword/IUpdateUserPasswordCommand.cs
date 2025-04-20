namespace Consultoria.Inversion.Application.Database.User.Commands.UpdateUserPassword
{
    public interface IUpdateUserPasswordCommand
    {
        Task<bool> Execute (UpdateUserPasswordModel model);
    }
}