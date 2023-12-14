using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Turno : BaseEntity
{
    //public int Id { get; set; }
    public string NombreTurno { get; set; }
    public TimeOnly HoraTurnoI { get; set; }
    public TimeOnly HoraTurnoF { get; set; }
    public ICollection<Programacion> Programaciones { get; set; }
}
