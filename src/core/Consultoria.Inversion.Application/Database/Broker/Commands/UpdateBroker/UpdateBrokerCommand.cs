using AutoMapper;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Database.Broker.Commands.UpdateBroker
{
    public class UpdateBrokerCommand : IUpdateBrokerCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public UpdateBrokerCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<UpdateBrokerModel> Execute (UpdateBrokerModel model)
        {
            var Instancia = _mapper.Map<BrokerModel>(model);
            _databaseService.Broker.Update(Instancia);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}