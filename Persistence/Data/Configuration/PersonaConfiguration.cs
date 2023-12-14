using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("persona");

        builder.HasIndex(e => e.IdCat, "idCat");

        builder.HasIndex(e => e.IdCiudad, "idCiudad");

        builder.HasIndex(e => e.IdPersona, "idPersona").IsUnique();

        builder.HasIndex(e => e.IdTpersona, "idTpersona");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.DateReg).HasColumnName("dateReg");
        builder.Property(e => e.IdCat).HasColumnName("idCat");
        builder.Property(e => e.IdCiudad).HasColumnName("idCiudad");
        builder.Property(e => e.IdPersona)
            .HasMaxLength(50)
            .HasColumnName("idPersona");
        builder.Property(e => e.IdTpersona).HasColumnName("idTpersona");
        builder.Property(e => e.Nombre)
            .HasMaxLength(100)
            .HasColumnName("nombre");

        builder.HasOne(d => d.CategoriaPer).WithMany(p => p.Personas)
            .HasForeignKey(d => d.IdCat)
            .HasConstraintName("persona_ibfk_2");

        builder.HasOne(d => d.Ciudad).WithMany(p => p.Personas)
            .HasForeignKey(d => d.IdCiudad)
            .HasConstraintName("persona_ibfk_3");

        builder.HasOne(d => d.TipoPersona).WithMany(p => p.Personas)
            .HasForeignKey(d => d.IdTpersona)
            .HasConstraintName("persona_ibfk_1");
    }
}
