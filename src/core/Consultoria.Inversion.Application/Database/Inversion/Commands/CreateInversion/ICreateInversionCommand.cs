namespace Consultoria.Inversion.Application.Database.Inversion.Commands.CreateInversion
{
    public interface ICreateInversionCommand
    {
        Task<CreateInversionModel> Execute(CreateInversionModel model);
    }
}