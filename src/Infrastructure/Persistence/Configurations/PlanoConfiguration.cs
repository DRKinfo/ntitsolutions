using ntitsolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ntitsolutions.Infrastructure.Persistence.Configurations;

public class PlanoConfiguration : IEntityTypeConfiguration<Plano>
{
    public void Configure(EntityTypeBuilder<Plano> builder)
    {
        builder.Property(t => t.Nome)
            .HasMaxLength(15)
            .IsRequired();
    }
}
