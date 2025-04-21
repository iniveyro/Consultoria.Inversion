namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetAllInversiones
{
    public class GetAllInversionesModel
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
        public required string BrokerNomb {get;set;}
        public required string UserName {get;set;}
    }
}