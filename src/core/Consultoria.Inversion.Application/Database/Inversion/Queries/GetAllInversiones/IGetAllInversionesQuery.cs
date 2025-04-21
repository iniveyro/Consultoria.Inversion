namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetAllInversiones
{
    public interface IGetAllInversionesQuery
    {
       Task<List<GetAllInversionesModel>> Execute();
    }
}