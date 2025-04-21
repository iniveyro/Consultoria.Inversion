namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByTipo
{
    public class GetInversionByTipoModel
    {
    public int NroInversion { get; set; }
    public required string Nombre {get; set;}
    public required string Tipo {get; set;}
    public required string Estado {get; set;}
    public int Rendimiento {get; set;}
    public int UserDNI {get; set;}
    }
}