
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Persistence.Configurations;

public class BicicletaConfiguration : IEntityTypeConfiguration<Bicicleta>
{
    public void Configure(EntityTypeBuilder<Bicicleta> builder)
    {
        builder.ToTable("Bicicletas");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Marca)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(x => x.Modelo)
               .IsRequired()
               .HasMaxLength(100);

        builder.HasOne(x => x.Cliente)
               .WithMany(c => c.Bicicletas)
               .HasForeignKey(x => x.ClienteId);
    }
}
