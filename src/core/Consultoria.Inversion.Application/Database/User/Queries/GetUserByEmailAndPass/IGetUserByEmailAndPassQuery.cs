namespace Consultoria.Inversion.Application.Database.User.Queries.GetUserByEmailAndPass
{
    public interface IGetUserByEmailAndPassQuery
    {
        Task<GetUserByEmailAndPassModel> Execute(string Email, string Password);
    }
}