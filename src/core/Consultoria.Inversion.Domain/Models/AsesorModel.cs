using Consultoria.Inversion.Domain.Enums;

namespace Consultoria.Inversion.Domain.Models
{
    public class AsesorModel
    {
        public int AsesorId {get;set;}
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public Certificaciones Certificacion {get;set;}
        public required string Email {get;set;}
        public ICollection<InversionModel> Inversiones {get;set;}
    }
}