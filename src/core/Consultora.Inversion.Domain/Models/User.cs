namespace Consultora.Inversion.Domain.Entities
{
    public class User
    {
        public int UserId {get;set;}
        public int NombApe {get;set;}
        public int Email {get;set;}
        public int Password {get;set;}
        public int DNI {get;set;}
        public string Tipo {get;set;}
        public DateOnly FechaRegistro {get;set;} 
    }
}