using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Estado : BaseEntity
{
    //public int Id { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; }
}
