namespace Consultoria.Inversion.Domain.Models;

public class InversionModel
{
    public int NroInversion { get; set; }
    public required string Nombre {get; set;}
    public required string Tipo {get; set;} //Enum
    public int Monto {get; set;}
    public DateOnly FechaInicio {get; set;}
    public DateOnly FechaVencimiento {get; set;}
    public required string Moneda {get; set;} //Enum
    public required string Estado {get; set;} //Enum
    public int Rendimiento {get; set;}
    //Claves Foraneas
    public int UserId {get;set;}
    public int AsesorId {get;set;}
    public UserModel User {get;set;}
    public AsesorModel Asesor {get;set;}
}