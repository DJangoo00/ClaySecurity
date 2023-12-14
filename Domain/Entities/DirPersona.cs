using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DirPersona : BaseEntity
{
    //public int Id { get; set; }

    public string Direccion { get; set; }

    public int IdPersona { get; set; }
    public Persona Persona { get; set; }
    public int IdTDireccion { get; set; }
    public TipoDireccion TipoDireccion { get; set; }
}
