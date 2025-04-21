namespace Consultoria.Inversion.Application.Database.Broker.Queries.GetAllBroker
{
    public interface IGetAllBrokersQuery
    {
        Task<List<GetAllBrokersModel>> Execute ();
    }
}