using Microsoft.EntityFrameworkCore;

namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByDNI
{
    public class GetInversionByDNIQuery : IGetInversionByDNIQuery
    { 
    private readonly IDatabaseService _databaseService;
        public GetInversionByDNIQuery(IDatabaseService databaseService)
        {
            _databaseService=databaseService;
        }   

        public async Task<List<GetInversionByDNIModel>>Execute(int DNI)
        {
            var result = await (
                from Inversiones in _databaseService.Inversion
                join Users in _databaseService.User
                on Inversiones.UserId equals Users.UserId
                where Users.DNI == DNI
                select new GetInversionByDNIModel
                {
                    NroInversion = Inversiones.NroInversion,
                    Nombre = Inversiones.Nombre,
                    Tipo = Inversiones.Tipo,
                    Monto = Inversiones.Monto,
                    FechaInicio = Inversiones.FechaInicio,
                    FechaVencimiento = Inversiones.FechaVencimiento,
                    Moneda = Inversiones.Moneda,
                    Estado = Inversiones.Estado,
                    Rendimiento = Inversiones.Rendimiento,
                    UserDNI = Users.DNI
                }
            ).ToListAsync();
            return result;
        }
    
    }
}