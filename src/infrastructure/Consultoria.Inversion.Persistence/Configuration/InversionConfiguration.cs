using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Consultoria.Inversion.Domain.Models;

namespace Consultoria.Inversion.Persistence.Configuration
{
    public class InversionConfiguration
    {
        public InversionConfiguration(EntityTypeBuilder<InversionModel> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.NroInversion);
            entityBuilder.Property(x=>x.Nombre).IsRequired();
            entityBuilder.Property(x=>x.Estado).IsRequired();
            entityBuilder.Property(x=>x.FechaInicio).IsRequired();
            entityBuilder.Property(x=>x.FechaVencimiento).IsRequired();
            entityBuilder.Property(x=>x.Moneda).IsRequired();
            entityBuilder.Property(x=>x.Monto).IsRequired();
            entityBuilder.Property(x=>x.Rendimiento).IsRequired();
            entityBuilder.Property(x=>x.Tipo).IsRequired();
            //Claves foraneas
            entityBuilder.Property(x=>x.AsesorId).IsRequired();
            entityBuilder.Property(x=>x.UserId).IsRequired();
            entityBuilder.HasOne(x=>x.User)
                .WithMany(x=>x.Inversiones)
                .HasForeignKey(x=>x.UserId);
            entityBuilder.HasOne(x=>x.Asesor)
                .WithMany(x=>x.Inversiones)
                .HasForeignKey(x=>x.AsesorId);
        }
    }
}