﻿using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipoPersona : BaseEntity
{
    //public int Id { get; set; }
    public string Descripcion { get; set; }
    public ICollection<Persona> Personas { get; set; }
}
