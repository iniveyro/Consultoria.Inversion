using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultoria.Inversion.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultoria.Inversion.Persistence.Configuration
{
    public class AsesorConfiguration
    {
        public AsesorConfiguration(EntityTypeBuilder<AsesorModel> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.AsesorId);
            entityBuilder.Property(x=>x.Certificacion).IsRequired();
            entityBuilder.Property(x=>x.DNI).IsRequired();
            entityBuilder.Property(x=>x.Email).IsRequired();
            entityBuilder.Property(x=>x.NombApe).IsRequired();
            entityBuilder.HasMany(x=>x.Inversiones)
            .WithOne(x=>x.Asesor)
            .HasForeignKey(x=>x.AsesorId);   
        }
    }
}