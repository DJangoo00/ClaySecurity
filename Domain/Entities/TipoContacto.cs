﻿using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipoContacto : BaseEntity
{
    //public int Id { get; set; }
    public string Descripcion { get; set; }
    public ICollection<ContactoPer> ContactoPers { get; set; }
}
