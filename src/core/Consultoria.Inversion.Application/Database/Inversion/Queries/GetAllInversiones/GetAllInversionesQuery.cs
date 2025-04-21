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
                join Broker in _databaseService.Broker on Inversiones.BrokerId equals Broker.BrokerId
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
                    BrokerNomb=Broker.NombApe,
                    UserName=User.NombApe
                }
            ).ToListAsync();
            return result;
        }
    }
}