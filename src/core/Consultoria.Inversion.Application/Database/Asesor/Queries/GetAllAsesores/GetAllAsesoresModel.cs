using Consultoria.Inversion.Domain.Enums;

namespace Consultoria.Inversion.Application.Database.Asesor.Queries.GetAllAsesores
{
    public class GetAllAsesoresModel
    {
        public int AsesorId {get;set;}
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public Certificaciones Certificacion {get;set;}
        public required string Email {get;set;}
    }
}