using Consultoria.Inversion.Domain.Enums;

namespace Consultoria.Inversion.Application.Database.Inversion.Commands.CreateInversion
{
    public class CreateInversionModel
    {
    public required string Nombre {get; set;}
    public TipoInversion Tipo {get; set;}
    public int Monto {get; set;}
    public DateOnly FechaInicio {get; set;}
    public DateOnly FechaVencimiento {get; set;}
    public Moneda Moneda {get; set;}
    public EstadoInversion Estado {get; set;}
    public int Rendimiento {get; set;}
    public int UserId {get;set;}
    public int AsesorId {get;set;}
    }
}