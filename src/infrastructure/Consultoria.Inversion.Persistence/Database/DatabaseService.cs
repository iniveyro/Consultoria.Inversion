using Consultoria.Inversion.Domain.Models;
using Consultoria.Inversion.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Consultoria.Inversion.Application.Database;

namespace Consultoria.Inversion.Persistence.Database
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserModel> User {get;set;}
        public DbSet<BrokerModel> Broker {get;set;}
        public DbSet<InversionModel> Inversion {get;set;}
        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0; // Retorna true o false si hubieron registros modificados
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }
        private void EntityConfiguration (ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<UserModel>());
            new BrokerConfiguration(modelBuilder.Entity<BrokerModel>());
            new InversionConfiguration(modelBuilder.Entity<InversionModel>());
        }
    
    }
}