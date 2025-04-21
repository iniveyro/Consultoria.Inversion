namespace Consultoria.Inversion.Application.Database.Asesor.Commands.UpdateAsesor
{
    public interface IUpdateAsesorCommand
    {
        Task<UpdateAsesorModel> Execute (UpdateAsesorModel model);
    }
}