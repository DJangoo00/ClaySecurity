using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Contrato : BaseEntity
{
    //public int Id { get; set; }

    public DateOnly FechaContrato { get; set; }
    public DateOnly FechaFin { get; set; }
    public int IdCliente { get; set; }
    public Persona Cliente { get; set; }
    public int IdEmpleado { get; set; }
    public Persona Empleado { get; set; }
    public int IdEstado { get; set; }    
    public Estado Estado { get; set; }
    public ICollection<Programacion> Programaciones { get; set; }
}
