namespace Consultoria.Inversion.Application.Database.User.Commands.CreateUser
{
    public class CreateUserModel
    {
        public required string NombApe {get;set;}
        public required string Email {get;set;}
        public required string Password {get;set;}
        public int DNI {get;set;}
        public required string Tipo {get;set;}
        public DateOnly FechaRegistro {get;set;} 
    }
}