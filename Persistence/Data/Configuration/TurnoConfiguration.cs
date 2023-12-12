using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class TurnoConfiguration : IEntityTypeConfiguration<Turno>
{
    public void Configure(EntityTypeBuilder<Turno> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("turno");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.HoraTurnoF)
            .HasColumnType("time")
            .HasColumnName("horaTurnoF");
        builder.Property(e => e.HoraTurnoI)
            .HasColumnType("time")
            .HasColumnName("horaTurnoI");
        builder.Property(e => e.NombreTurno)
            .HasMaxLength(50)
            .HasColumnName("nombreTurno");
    }
}
