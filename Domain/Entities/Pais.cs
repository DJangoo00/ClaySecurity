﻿using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Pais : BaseEntity
{
    //public int Id { get; set; }

    public string NombrePais { get; set; }

    public virtual ICollection<Departamento> Departamentos { get; set; }
}