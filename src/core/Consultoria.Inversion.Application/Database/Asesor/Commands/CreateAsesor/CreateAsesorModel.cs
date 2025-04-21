namespace Consultoria.Inversion.Application.Database.Asesor.Commands.CreateAsesor
{
    public class CreateAsesorModel
    {
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public required string Email {get;set;}
        public required string Certificaciones {get;set;}
    }
}