using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Contrato : BaseEntity
{
    //public int Id { get; set; }

    public DateOnly FechaContrato { get; set; }

    public DateOnly FechaFin { get; set; }

    public int IdCliente { get; set; }

    public int IdEmpleado { get; set; }

    public int IdEstado { get; set; }

    public virtual Persona Cliente { get; set; } = null!;

    public virtual Persona Empleado { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual ICollection<Programacion> Programaciones { get; set; } = new List<Programacion>();
}
