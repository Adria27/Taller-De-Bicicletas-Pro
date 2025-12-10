using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Persistence.Configurations
{
    public class BicicletaConfiguration : IEntityTypeConfiguration<Bicicleta>
    {
        public void Configure(EntityTypeBuilder<Bicicleta> builder)
        {
            builder.ToTable("Bicicletas");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Modelo)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.Color)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.Precio)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            // Si luego necesitas relación con Reparaciones, se agrega aquí.
        }
    }
}
