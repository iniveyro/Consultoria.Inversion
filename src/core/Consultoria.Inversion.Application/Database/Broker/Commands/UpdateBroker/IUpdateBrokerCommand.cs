namespace Consultoria.Inversion.Application.Database.Broker.Commands.UpdateBroker
{
    public interface IUpdateBrokerCommand
    {
        Task<UpdateBrokerModel> Execute (UpdateBrokerModel model);
    }
}