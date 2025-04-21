using Consultoria.Inversion.Domain.Enums;

namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByTipo
{
    public interface IGetInversionByTipoQuery
    {
    Task<List<GetInversionByTipoModel>> Execute(TipoInversion TipoInversion);
    }
}