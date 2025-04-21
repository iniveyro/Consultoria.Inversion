namespace Consultoria.Inversion.Domain.Models
{
    public class UserModel
    {
        public int UserId {get;set;}
        public required string NombApe {get;set;}
        public required string Email {get;set;}
        public required string Password {get;set;}
        public int DNI {get;set;}
        public int Tipo {get;set;} //Enum
        public DateOnly FechaRegistro {get;set;} 
        //Clave Foraneas
        public int AsesorId {get;set;}
        public AsesorModel Asesor {get;set;}
        public ICollection<InversionModel> Inversiones {get;set;}
    }
}