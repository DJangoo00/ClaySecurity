using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Ciudad : BaseEntity
{
    //public int Id { get; set; }

    public string NombreCiudad { get; set; }
    public int IdDepartamento { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<Persona> Personas { get; set; }
}
