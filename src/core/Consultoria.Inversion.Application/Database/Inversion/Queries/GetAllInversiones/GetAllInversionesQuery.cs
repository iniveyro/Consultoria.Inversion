using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetAllInversiones
{
    public class GetAllInversionesQuery : IGetAllInversionesQuery
    {
        private readonly IDatabaseService _databaseService;
        public GetAllInversionesQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<List<GetAllInversionesModel>> Execute()
        {
            var result = await (
                from Inversiones in _databaseService.Inversion
                join Asesor in _databaseService.Asesor on Inversiones.AsesorId equals Asesor.AsesorId
                join User in _databaseService.User on Inversiones.UserId equals User.UserId
                select new GetAllInversionesModel
                {
                    NroInversion=Inversiones.NroInversion,
                    Nombre = Inversiones.Nombre,
                    Monto = Inversiones.Monto,
                    Moneda = Inversiones.Moneda,
                    FechaInicio = Inversiones.FechaInicio,
                    FechaVencimiento = Inversiones.FechaVencimiento,
                    Estado = Inversiones.Estado,
                    Rendimiento = Inversiones.Rendimiento,
                    Tipo = Inversiones.Tipo,
                    AsesorNomb=Asesor.NombApe,
                    UserName=User.NombApe
                }
            ).ToListAsync();
            return result;
        }
    }
}