namespace Consultoria.Inversion.Application.Database.Broker.Commands.CreateBroker
{
    public interface ICreateBrokerCommand
    {
        Task<CreateBrokerModel> Execute(CreateBrokerModel model);
    }
}