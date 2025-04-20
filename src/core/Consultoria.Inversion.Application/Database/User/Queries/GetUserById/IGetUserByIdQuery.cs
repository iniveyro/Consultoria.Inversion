namespace Consultoria.Inversion.Application.Database.User.Queries.GetUserById
{
    public interface IGetUserByIdQuery
    {
        Task<GetUserByIdModel> Execute(int UserId);
    }
}