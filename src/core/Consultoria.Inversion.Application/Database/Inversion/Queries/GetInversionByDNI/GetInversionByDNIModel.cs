namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByDNI
{
    public class GetInversionByDNIModel
    {
    public int NroInversion { get; set; }
    public required string Nombre {get; set;}
    public required string Tipo {get; set;}
    public int Monto {get; set;}
    public DateOnly FechaInicio {get; set;}
    public DateOnly FechaVencimiento {get; set;}
    public required string Moneda {get; set;}
    public required string Estado {get; set;}
    public int Rendimiento {get; set;}
    public int UserDNI {get;set;}
    }
}