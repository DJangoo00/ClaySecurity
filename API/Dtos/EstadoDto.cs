﻿using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class EstadoDto : BaseEntity
{
    //public int Id { get; set; }
    public string Descripcion { get; set; }
}
