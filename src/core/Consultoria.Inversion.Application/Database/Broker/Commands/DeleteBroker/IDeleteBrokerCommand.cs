namespace Consultoria.Inversion.Application.Database.Broker.Commands.DeleteBroker
{
    public interface IDeleteBrokerCommand
    {
        Task<bool> Execute (int BrokerId);
    }
}