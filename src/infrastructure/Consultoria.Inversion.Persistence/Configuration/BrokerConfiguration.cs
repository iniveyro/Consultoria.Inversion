using Consultoria.Inversion.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultoria.Inversion.Persistence.Configuration
{
    public class BrokerConfiguration
    {
        public BrokerConfiguration(EntityTypeBuilder<BrokerModel> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.BrokerId);
            entityBuilder.Property(x=>x.Certificacion);
            entityBuilder.Property(x=>x.DNI).IsRequired();
            entityBuilder.Property(x=>x.Email).IsRequired();
            entityBuilder.Property(x=>x.NombApe).IsRequired();
            entityBuilder.HasMany(x=>x.Inversiones)
            .WithOne(x=>x.Broker)
            .HasForeignKey(x=>x.BrokerId);   
        }
    }
}