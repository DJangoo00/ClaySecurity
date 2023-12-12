using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
{
    public void Configure(EntityTypeBuilder<Contrato> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("contrato");

        builder.HasIndex(e => e.IdCliente, "idCliente");

        builder.HasIndex(e => e.IdEmpleado, "idEmpleado");

        builder.HasIndex(e => e.IdEstado, "idEstado");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.FechaContrato).HasColumnName("fechaContrato");
        builder.Property(e => e.FechaFin).HasColumnName("fechaFin");
        builder.Property(e => e.IdCliente).HasColumnName("idCliente");
        builder.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
        builder.Property(e => e.IdEstado).HasColumnName("idEstado");

        builder.HasOne(d => d.Cliente).WithMany(p => p.ContratoIdClienteNavigations)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("contrato_ibfk_1");

        builder.HasOne(d => d.Empleado).WithMany(p => p.ContratoIdEmpleadoNavigations)
            .HasForeignKey(d => d.IdEmpleado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("contrato_ibfk_2");

        builder.HasOne(d => d.Estado).WithMany(p => p.Contratos)
            .HasForeignKey(d => d.IdEstado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("contrato_ibfk_3");
    }
}
