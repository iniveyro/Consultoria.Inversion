namespace Consultoria.Inversion.Domain.Models
{
    public class BrokerModel
    {
        public int BrokerId {get;set;}
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public string? Certificacion {get;set;} //Enum
        public required string Email {get;set;}
        public ICollection<InversionModel> Inversiones {get;set;}
    }
}