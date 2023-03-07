using ntitsolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ntitsolutions.Infrastructure.Persistence.Configurations;

public class TarifaConfiguration : IEntityTypeConfiguration<Tarifa>
{
    public void Configure(EntityTypeBuilder<Tarifa> builder)
    {
        builder.Property(t => t.Origem)
            .HasMaxLength(3)
            .IsRequired();
        builder.Property(t => t.Destino)
            .HasMaxLength(3)
            .IsRequired();
        builder.Property(t => t.Valor)
            .HasPrecision(10,2).IsRequired();
    }
}
