namespace Consultoria.Inversion.Application.Database.Asesor.Queries.GetAsesorByDNI
{
    public class GetAsesorByDNIModel
    {
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public required string Email {get;set;}
    }
}