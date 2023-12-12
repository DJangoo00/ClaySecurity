using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Departamento : BaseEntity
{
    //public int Id { get; set; }

    public string NombreDepartamento { get; set; }

    public int IdPais { get; set; }

    public virtual ICollection<Ciudad> Ciudades { get; set; }

    public virtual Pais Pais { get; set; }
}
