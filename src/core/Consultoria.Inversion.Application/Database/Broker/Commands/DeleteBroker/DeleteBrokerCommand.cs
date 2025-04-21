using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Broker.Commands.DeleteBroker
{
    public class DeleteBrokerCommand : IDeleteBrokerCommand
    {
        private readonly IDatabaseService _databaseService;
        public DeleteBrokerCommand(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<bool> Execute (int BrokerId)
        {
            var Instancia = await _databaseService.Broker.FirstOrDefaultAsync(x=>x.BrokerId==BrokerId);
            if (Instancia == null)
                return false;
            _databaseService.Broker.Remove(Instancia);
            return await _databaseService.SaveAsync();
        }
    }
}