using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Ciudad : BaseEntity
{
    //public int Id { get; set; }

    public string NombreCiudad { get; set; }

    public int IdDepartamento { get; set; }

    public virtual Departamento Departamento { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
