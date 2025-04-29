namespace Consultoria.Inversion.Application.Database.User.Queries.GetUserByEmailAndPass
{
    public class GetUserByEmailAndPassModel
    {
        public int UserId {get;set;}
        public required string NombApe {get;set;}
        public required string Email {get;set;}
        public required string Password {get;set;}
        public string Token {get;set;}
    }
}