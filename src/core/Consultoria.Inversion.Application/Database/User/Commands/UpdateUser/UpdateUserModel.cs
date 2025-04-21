namespace Consultoria.Inversion.Application.Database.User.Commands.UpdateUser
{
    public class UpdateUserModel
    {
        public int UserId {get;set;}
        public required string Email {get;set;}
        public required string Password {get;set;}
        public required string NombApe {get;set;}
        public int AsesorId {get;set;}

    }
}