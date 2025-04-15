using Consultora.Inversion.Domain.Enums;

namespace Consultora.Inversion.Domain.Entities
{
    public class Asesor
    {
        public int AsesorID {get;set;}
        public string NombApe {get;set;}
        public int DNI {get;set;}
        public Certificaciones Certificacion {get;set;}
        public string Email {get;set;}
    }
}