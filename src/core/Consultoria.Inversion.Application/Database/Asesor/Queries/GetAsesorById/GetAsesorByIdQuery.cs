using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Asesor.Queries.GetAsesorById
{
    public class GetAsesorByIdQuery : IGetAsesorByIdQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAsesorByIdQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetAsesorByIdModel> Execute (int AsesorId)
        {
            var Instancia = await _databaseService.Asesor.FirstOrDefaultAsync(x=> x.AsesorId == AsesorId);
            return _mapper.Map<GetAsesorByIdModel>(Instancia);
        }
    }
}