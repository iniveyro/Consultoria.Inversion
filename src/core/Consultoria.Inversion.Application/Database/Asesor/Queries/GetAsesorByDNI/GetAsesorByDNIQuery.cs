using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Asesor.Queries.GetAsesorByDNI
{
    public class GetAsesorByDNIQuery : IGetAsesorByDNIQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAsesorByDNIQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetAsesorByDNIModel> Execute (int DNI)
        {
            var Instancia = await _databaseService.Asesor.FirstOrDefaultAsync(x=>x.DNI == DNI);
            return _mapper.Map<GetAsesorByDNIModel>(Instancia);
        }
    }
}