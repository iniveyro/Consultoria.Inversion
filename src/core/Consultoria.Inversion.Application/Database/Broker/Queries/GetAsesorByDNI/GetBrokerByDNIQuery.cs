using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Broker.Queries.GetBrokerByDNI
{
    public class GetBrokerByDNIQuery : IGetBrokerByDNIQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetBrokerByDNIQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetBrokerByDNIModel> Execute (int DNI)
        {
            var Instancia = await _databaseService.Broker.FirstOrDefaultAsync(x=>x.DNI == DNI);
            return _mapper.Map<GetBrokerByDNIModel>(Instancia);
        }
    }
}