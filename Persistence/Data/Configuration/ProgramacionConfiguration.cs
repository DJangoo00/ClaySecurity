using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class ProgramacionConfiguration : IEntityTypeConfiguration<Programacion>
{
    public void Configure(EntityTypeBuilder<Programacion> builder)
    {
        builder.HasKey(e => e.Id)
            .HasName("PRIMARY");

        builder.ToTable("programacion");

        builder.HasIndex(e => e.IdContrato, "idContrato");

        builder.HasIndex(e => e.IdEmpleado, "idEmpleado");

        builder.HasIndex(e => e.IdTurno, "idTurno");

        builder.Property(e => e.Id)
            .HasColumnName("id");

        builder.Property(e => e.IdContrato)
            .HasColumnName("idContacto");

        builder.Property(e => e.IdEmpleado)
            .HasColumnName("idEmpleado");

        builder.Property(e => e.IdTurno)
            .HasColumnName("idTurno");

        builder.HasOne(d => d.Contrato).WithMany(p => p.Programaciones)
            .HasForeignKey(d => d.IdContrato)
            .HasConstraintName("programacion_ibfk_1");

        builder.HasOne(d => d.Empleado).WithMany(p => p.Programaciones)
            .HasForeignKey(d => d.IdEmpleado)
            .HasConstraintName("programacion_ibfk_3");

        builder.HasOne(d => d.Turno).WithMany(p => p.Programaciones)
            .HasForeignKey(d => d.IdTurno)
            .HasConstraintName("programacion_ibfk_2");
    }
}
