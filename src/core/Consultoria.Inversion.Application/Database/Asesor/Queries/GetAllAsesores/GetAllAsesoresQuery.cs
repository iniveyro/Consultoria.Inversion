using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Asesor.Queries.GetAllAsesores
{
    public class GetAllAsesoresQuery : IGetAllAsesoresQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAllAsesoresQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper=mapper;
        }

        public async Task<List<GetAllAsesoresModel>> Execute ()
        {
            var listAsesores = await _databaseService.Asesor.ToListAsync();
            return _mapper.Map<List<GetAllAsesoresModel>>(listAsesores);
        } 
    }
}