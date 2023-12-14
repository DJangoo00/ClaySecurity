using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipoDireccion : BaseEntity
{
    //public int Id { get; set; }
    public string Descripcion { get; set; }
    public ICollection<DirPersona> DirPersonas { get; set; }
}
