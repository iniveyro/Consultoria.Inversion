using Microsoft.EntityFrameworkCore;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<UserModel> User {get;set;}
        DbSet<AsesorModel> Asesor {get;set;}
        DbSet<InversionModel> Inversion {get;set;}
        Task<bool> SaveAsync();
    }
}