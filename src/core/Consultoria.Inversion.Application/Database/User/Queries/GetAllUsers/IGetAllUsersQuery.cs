namespace Consultoria.Inversion.Application.Database.User.Queries.GetAllUsers
{
    public interface IGetAllUsersQuery
    {
        Task<List<GetAllUsersModel>> Execute ();
    }
}