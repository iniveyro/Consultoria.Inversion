using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerById
{
    public class GetBrokerByIdQuery : IGetBrokerByIdQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetBrokerByIdQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetBrokerByIdModel> Execute (int BrokerId)
        {
            var Instancia = await _databaseService.Broker.FirstOrDefaultAsync(x=> x.BrokerId == BrokerId);
            return _mapper.Map<GetBrokerByIdModel>(Instancia);
        }
    }
}