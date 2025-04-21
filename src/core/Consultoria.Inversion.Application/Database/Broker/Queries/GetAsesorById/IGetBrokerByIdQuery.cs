namespace Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerById
{
    public interface IGetBrokerByIdQuery
    {
        Task<GetBrokerByIdModel> Execute (int BrokerId);
    }
}