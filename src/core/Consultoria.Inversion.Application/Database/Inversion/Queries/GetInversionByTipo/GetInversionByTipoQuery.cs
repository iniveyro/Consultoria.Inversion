using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByTipo
{
    public class GetInversionByTipoQuery : IGetInversionByTipoQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetInversionByTipoQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<List<GetInversionByTipoModel>> Execute(string TipoInversion)
        {
            var result = await (
                from Inversiones in _databaseService.Inversion
                join Users in _databaseService.User
                on Inversiones.UserId equals Users.UserId
                where TipoInversion == Inversiones.Tipo
                select new GetInversionByTipoModel 
                {
                    NroInversion = Inversiones.NroInversion,
                    Nombre = Inversiones.Nombre,
                    Tipo = Inversiones.Tipo,
                    Estado = Inversiones.Estado,
                    Rendimiento = Inversiones.Rendimiento,
                    UserDNI = Users.DNI
                }
            ).ToListAsync();
            return result;
        }
    }
}