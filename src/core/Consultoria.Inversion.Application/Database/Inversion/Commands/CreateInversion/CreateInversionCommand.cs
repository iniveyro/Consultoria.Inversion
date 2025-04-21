using AutoMapper;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Database.Inversion.Commands.CreateInversion
{
    public class CreateInversionCommand : ICreateInversionCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public CreateInversionCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<CreateInversionModel> Execute(CreateInversionModel model)
        {
            var Inversion = _mapper.Map<InversionModel>(model);
            await _databaseService.Inversion.AddAsync(Inversion);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}