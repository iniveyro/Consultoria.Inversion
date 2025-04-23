namespace Consultoria.Inversion.Application.Database.User.Commands.UpdateUser
{
    public class UpdateUserModel
    {
        public int UserId {get;set;}
        public string NombApe {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public int DNI {get;set;}
        public string Tipo {get;set;}
    }
}