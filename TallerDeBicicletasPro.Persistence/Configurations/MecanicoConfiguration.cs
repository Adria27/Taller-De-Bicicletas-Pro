using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Persistence.Configurations;

public class MecanicoConfiguration : IEntityTypeConfiguration<Mecanico>
{
    public void Configure(EntityTypeBuilder<Mecanico> builder)
    {
        builder.ToTable("Mecanicos");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nombre)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(x => x.Especialidad)
               .HasMaxLength(150);
    }
}
