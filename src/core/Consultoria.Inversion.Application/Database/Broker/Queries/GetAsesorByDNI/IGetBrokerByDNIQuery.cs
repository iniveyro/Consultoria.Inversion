namespace Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerByDNI
{
    public interface IGetBrokerByDNIQuery
    {
        Task<GetBrokerByDNIModel> Execute (int DNI);
    }
}