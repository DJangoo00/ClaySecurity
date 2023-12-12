using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Programacion : BaseEntity
{
    //public int Id { get; set; }

    public int IdContrato { get; set; }

    public int IdTurno { get; set; }

    public int IdEmpleado { get; set; }

    public virtual Contrato Contrato { get; set; } = null!;

    public virtual Persona Empleado { get; set; } = null!;

    public virtual Turno Turno { get; set; } = null!;
}
