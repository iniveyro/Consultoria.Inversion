using Consultoria.Inversion.Domain.Enums;

namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetAllInversiones
{
    public class GetAllInversionesModel
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
        public string AsesorNomb {get;set;}
        public string UserName {get;set;}
    }
}