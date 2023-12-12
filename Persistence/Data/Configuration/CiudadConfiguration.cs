using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("ciudad");

        builder.HasIndex(e => e.IdDepartamento, "idDepartamento");

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IdDepartamento)
            .HasColumnName("idDepartamento");

        builder.Property(e => e.NombreCiudad)
            .HasMaxLength(50)
            .HasColumnName("nombreCiudad");

        builder.HasOne(d => d.Departamento)
            .WithMany(p => p.Ciudades)
            .HasForeignKey(d => d.IdDepartamento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("ciudad_ibfk_1");
    }
}
