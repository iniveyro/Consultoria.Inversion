namespace Consultoria.Inversion.Domain.Models
{
    public class UserModel
    {
        public int UserId {get;set;}
        public string NombApe {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public int DNI {get;set;}
        public string Tipo {get;set;}
        public DateOnly FechaRegistro {get;set;} 
        //Clave Foraneas
        public ICollection<InversionModel> Inversiones {get;set;}
    }
}