namespace Consultoria.Inversion.Application.Database.Asesor.Queries.GetAsesorById
{
    public interface IGetAsesorByIdQuery
    {
        Task<GetAsesorByIdModel> Execute (int AsesorId);
    }
}