using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class TurnoDto : BaseEntity
{
    //public int Id { get; set; }
    public string NombreTurno { get; set; }
    public TimeOnly HoraTurnoI { get; set; }
    public TimeOnly HoraTurnoF { get; set; }

}
