namespace Consultoria.Inversion.Application.Database.Asesor.Commands.CreateAsesor
{
    public interface ICreateAsesorCommand
    {
        Task<CreateAsesorModel> Execute(CreateAsesorModel model);
    }
}