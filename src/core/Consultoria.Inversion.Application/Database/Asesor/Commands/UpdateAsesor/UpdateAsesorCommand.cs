using AutoMapper;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Database.Asesor.Commands.UpdateAsesor
{
    public class UpdateAsesorCommand : IUpdateAsesorCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public UpdateAsesorCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<UpdateAsesorModel> Execute (UpdateAsesorModel model)
        {
            var Instancia = _mapper.Map<AsesorModel>(model);
            _databaseService.Asesor.Update(Instancia);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}