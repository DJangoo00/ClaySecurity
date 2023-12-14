using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class CategoriaPerConfiguration : IEntityTypeConfiguration<CategoriaPer>
{
    public void Configure(EntityTypeBuilder<CategoriaPer> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("categoriaper");

        builder.Property(e => e.Id)
            .HasColumnType("int")
            .HasColumnName("id");

        builder.Property(e => e.NombreCat)
            .HasMaxLength(50)
            .HasColumnName("nombreCat");
    }
}
