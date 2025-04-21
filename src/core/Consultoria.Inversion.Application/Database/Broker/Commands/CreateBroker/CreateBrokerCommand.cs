using AutoMapper;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Database.Broker.Commands.CreateBroker
{
    public class CreateBrokerCommand : ICreateBrokerCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public CreateBrokerCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService=databaseService;
            _mapper=mapper;
        }

        public async Task<CreateBrokerModel> Execute(CreateBrokerModel model)
        {
            var Instancia = _mapper.Map<BrokerModel>(model);
            await _databaseService.Broker.AddAsync(Instancia);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}