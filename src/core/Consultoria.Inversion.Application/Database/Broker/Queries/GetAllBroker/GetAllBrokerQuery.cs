using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Broker.Queries.GetAllBroker
{
    public class GetAllBrokersQuery : IGetAllBrokersQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAllBrokersQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper=mapper;
        }

        public async Task<List<GetAllBrokersModel>> Execute ()
        {
            var listBrokeres = await _databaseService.Broker.ToListAsync();
            return _mapper.Map<List<GetAllBrokersModel>>(listBrokeres);
        } 
    }
}