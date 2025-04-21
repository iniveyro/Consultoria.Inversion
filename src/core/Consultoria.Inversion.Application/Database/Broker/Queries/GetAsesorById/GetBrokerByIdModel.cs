namespace Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerById
{
    public class GetBrokerByIdModel
    {
        public int BrokerId {get;set;}
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public required string Certificacion {get;set;}
        public required string Email {get;set;}
    }
}