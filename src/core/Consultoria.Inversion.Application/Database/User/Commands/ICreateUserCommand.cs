namespace Consultoria.Inversion.Application.Database.User.Commands
{
    public interface ICreateUserCommand
    {
        Task<CreateUserModel> Execute(CreateUserModel model);
    }
}