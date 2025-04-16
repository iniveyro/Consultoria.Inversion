using Consultoria.Inversion.Domain.Enums;

namespace Consultoria.Inversion.Domain.Models;

public class InversionModel
{
    public int NroInversion { get; set; }
    public required string Nombre {get; set;}
    public TipoInversion Tipo {get; set;}
    public int Monto {get; set;}
    public DateOnly FechaInicio {get; set;}
    public DateOnly FechaVencimiento {get; set;}
    public Moneda Moneda {get; set;}
    public EstadoInversion Estado {get; set;}
    public int Rendimiento {get; set;}
    //Claves Foraneas
    public int UserId {get;set;}
    public int AsesorId {get;set;}

    public UserModel User {get;set;}
    public AsesorModel Asesor {get;set;}
}