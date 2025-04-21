using AutoMapper;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Database.Asesor.Commands.CreateAsesor
{
    public class CreateAsesorCommand : ICreateAsesorCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public CreateAsesorCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService=databaseService;
            _mapper=mapper;
        }

        public async Task<CreateAsesorModel> Execute(CreateAsesorModel model)
        {
            var Instancia = _mapper.Map<AsesorModel>(model);
            await _databaseService.Asesor.AddAsync(Instancia);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}