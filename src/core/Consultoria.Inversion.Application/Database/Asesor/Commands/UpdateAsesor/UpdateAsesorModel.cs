namespace Consultoria.Inversion.Application.Database.Asesor.Commands.UpdateAsesor
{
    public class UpdateAsesorModel
    {
        public int AsesorId {get;set;}
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public required string Certificacion {get;set;}
        public required string Email {get;set;}
    }
}