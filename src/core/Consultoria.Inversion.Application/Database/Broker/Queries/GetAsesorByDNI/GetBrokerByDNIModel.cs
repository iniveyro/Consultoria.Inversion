namespace Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerByDNI
{
    public class GetBrokerByDNIModel
    {
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public required string Email {get;set;}
    }
}