
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Persistence.Configurations;

public class ReparacionConfiguration : IEntityTypeConfiguration<Reparacion>
{
    public void Configure(EntityTypeBuilder<Reparacion> builder)
    {
        builder.ToTable("Reparaciones");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Descripcion)
               .HasMaxLength(250);

        builder.Property(x => x.Costo)
               .HasPrecision(10, 2);

        builder.HasOne(x => x.Bicicleta)
               .WithMany(b => b.Reparaciones)
               .HasForeignKey(x => x.BicicletaId);

        builder.HasOne(x => x.Mecanico)
               .WithMany(m => m.Reparaciones)
               .HasForeignKey(x => x.MecanicoId);
    }
}
