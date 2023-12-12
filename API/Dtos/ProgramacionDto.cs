using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class ProgramacionDto : BaseEntity
{
    //public int Id { get; set; }
    public int IdContrato { get; set; }
    public int IdTurno { get; set; }
    public int IdEmpleado { get; set; }
    public Contrato Contrato { get; set; }
    public Persona Empleado { get; set; }
    public Turno Turno { get; set; }
}
