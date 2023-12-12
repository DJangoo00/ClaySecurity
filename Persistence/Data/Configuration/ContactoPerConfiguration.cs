using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class ContactoPerConfiguration : IEntityTypeConfiguration<ContactoPer>
{
    public void Configure(EntityTypeBuilder<ContactoPer> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("contactoper");

        builder.HasIndex(e => e.Descripcion, "descripcion").IsUnique();

        builder.HasIndex(e => e.IdPersona, "idPersona");

        builder.HasIndex(e => e.IdTContacto, "idTContacto");

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.Descripcion)
            .HasMaxLength(50)
            .HasColumnName("descripcion");

        builder.Property(e => e.IdPersona)
            .HasColumnName("idPersona");

        builder.Property(e => e.TipoContacto)
            .HasColumnName("idTContacto");

        builder.HasOne(d => d.Persona)
            .WithMany(p => p.ContactoPers)
            .HasForeignKey(d => d.IdPersona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("contactoper_ibfk_1");

        builder.HasOne(d => d.TipoContacto)
            .WithMany(p => p.ContactoPers)
            .HasForeignKey(d => d.TipoContacto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("contactoper_ibfk_2");
    }
}
