using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class DirPersonaConfiguration : IEntityTypeConfiguration<DirPersona>
{
    public void Configure(EntityTypeBuilder<DirPersona> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("dirpersona");

        builder.HasIndex(e => e.IdPersona, "idPersona");

        builder.HasIndex(e => e.TipoDireccion, "idTDireccion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Direccion)
            .HasMaxLength(50)
            .HasColumnName("direccion");
        builder.Property(e => e.IdPersona).HasColumnName("idPersona");
        builder.Property(e => e.TipoDireccion).HasColumnName("idTDireccion");

        builder.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Dirpersonas)
            .HasForeignKey(d => d.IdPersona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("dirpersona_ibfk_1");

        builder.HasOne(d => d.TipoDireccion).WithMany(p => p.DirPersonas)
            .HasForeignKey(d => d.TipoDireccion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("dirpersona_ibfk_2");
    }
}
