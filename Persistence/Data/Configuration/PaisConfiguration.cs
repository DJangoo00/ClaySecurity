using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("pais");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.NombrePais)
            .HasMaxLength(50)
            .HasColumnName("nombrePais");
    }
}
