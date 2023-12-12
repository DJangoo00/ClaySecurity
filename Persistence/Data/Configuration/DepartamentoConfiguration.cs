using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("departamento");

        builder.HasIndex(e => e.IdPais, "idPais");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdPais).HasColumnName("idPais");
        builder.Property(e => e.NombreDepartamento)
            .HasMaxLength(50)
            .HasColumnName("nombreDepartamento");

        builder.HasOne(d => d.Pais).WithMany(p => p.Departamentos)
            .HasForeignKey(d => d.IdPais)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("departamento_ibfk_1");
    }
}
