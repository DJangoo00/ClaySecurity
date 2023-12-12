using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class ContratoDto : BaseEntity
{
    //public int Id { get; set; }

    public DateOnly FechaContrato { get; set; }

    public DateOnly FechaFin { get; set; }

    public int IdCliente { get; set; }

    public int IdEmpleado { get; set; }

    public int IdEstado { get; set; }

    public Persona Cliente { get; set; }

    public Persona Empleado { get; set; }

    public Estado Estado { get; set; }

}
