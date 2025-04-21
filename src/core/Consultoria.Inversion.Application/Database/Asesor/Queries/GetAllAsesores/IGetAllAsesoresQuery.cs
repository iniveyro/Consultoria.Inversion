namespace Consultoria.Inversion.Application.Database.Asesor.Queries.GetAllAsesores
{
    public interface IGetAllAsesoresQuery
    {
        Task<List<GetAllAsesoresModel>> Execute ();
    }
}