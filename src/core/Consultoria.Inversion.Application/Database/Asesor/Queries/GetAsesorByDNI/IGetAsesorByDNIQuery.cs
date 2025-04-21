namespace Consultoria.Inversion.Application.Database.Asesor.Queries.GetAsesorByDNI
{
    public interface IGetAsesorByDNIQuery
    {
        Task<GetAsesorByDNIModel> Execute (int DNI);
    }
}