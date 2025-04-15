using Consultora.Inversion.Domain.Enums;

namespace Consultora.Inversion.Domain.Entities;

public class Inversion
{
    public int NroInversion { get; set; }
    public string NombApe {get; set;}
    public string Tipo {get; set;}
    public int Monto {get; set;}
    public DateOnly FechaInicio {get; set;}
    public DateOnly FechaVencimiento {get; set;}
    public Moneda Moneda {get; set;}
    public EstadoInversion Estado {get; set;}
    public int Rendimiento {get; set;}
}