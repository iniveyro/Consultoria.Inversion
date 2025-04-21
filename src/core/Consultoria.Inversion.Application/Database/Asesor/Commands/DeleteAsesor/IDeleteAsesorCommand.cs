namespace Consultoria.Inversion.Application.Database.Asesor.Commands.DeleteAsesor
{
    public interface IDeleteAsesorCommand
    {
        Task<bool> Execute (int AsesorId);
    }
}