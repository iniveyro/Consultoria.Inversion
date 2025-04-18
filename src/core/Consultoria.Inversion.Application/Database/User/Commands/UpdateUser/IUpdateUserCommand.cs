namespace Consultoria.Inversion.Application.Database.User.Commands.UpdateUser
{
    public interface IUpdateUserCommand
    {
        Task<UpdateUserModel> Execute (UpdateUserModel model);
    }
}