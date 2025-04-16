using Microsoft.EntityFrameworkCore.ChangeTracking;
using Consultoria.Inversion.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultoria.Inversion.Persistence.Configuration;

public class UserConfiguration
{
    public UserConfiguration(EntityTypeBuilder<UserModel> entityBuilder)
    {
        entityBuilder.HasKey(x => x.UserId);
        entityBuilder.Property(x => x.DNI).IsRequired();
        entityBuilder.Property(x => x.Email).IsRequired();
        entityBuilder.Property(x => x.FechaRegistro).IsRequired();
        entityBuilder.Property(x => x.NombApe).IsRequired();
        entityBuilder.Property(x => x.Password).IsRequired();
        entityBuilder.Property(x => x.Tipo).IsRequired();
        //Clave Foranea
        entityBuilder.Property(x=>x.AsesorId).IsRequired();
    }
}