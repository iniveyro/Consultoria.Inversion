using Microsoft.EntityFrameworkCore;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Application.Database
{
    public interface IDatabaseService
    {
        DbSet<UserModel> User {get;set;}
        DbSet<BrokerModel> Broker {get;set;}
        DbSet<InversionModel> Inversion {get;set;}
        Task<bool> SaveAsync();
    }
}