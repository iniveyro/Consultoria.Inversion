using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Asesor.Commands.DeleteAsesor
{
    public class DeleteAsesorCommand : IDeleteAsesorCommand
    {
        private readonly IDatabaseService _databaseService;
        public DeleteAsesorCommand(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<bool> Execute (int AsesorId)
        {
            var Instancia = await _databaseService.Asesor.FirstOrDefaultAsync(x=>x.AsesorId==AsesorId);
            if (Instancia == null)
                return false;
            _databaseService.Asesor.Remove(Instancia);
            return await _databaseService.SaveAsync();
        }
    }
}