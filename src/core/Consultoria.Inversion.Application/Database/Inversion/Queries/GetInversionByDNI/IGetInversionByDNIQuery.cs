namespace Consultoria.Inversion.Application.Database.Inversion.Queries.GetInversionByDNI
{
    public interface IGetInversionByDNIQuery
    {
        Task<List<GetInversionByDNIModel>>Execute(int DNI);
    }
}