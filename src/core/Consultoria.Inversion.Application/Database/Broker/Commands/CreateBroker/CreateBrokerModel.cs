namespace Consultoria.Inversion.Application.Database.Broker.Commands.CreateBroker
{
    public class CreateBrokerModel
    {
        public required string NombApe {get;set;}
        public int DNI {get;set;}
        public required string Email {get;set;}
        public required string Certificacion {get;set;}
    }
}