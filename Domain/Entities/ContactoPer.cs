using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ContactoPer : BaseEntity
{
    //public int Id { get; set; }

    public string Descripcion { get; set; }
    public int IdPersona { get; set; }
    public Persona Persona { get; set; }
    public int IdTContacto { get; set; }
    public TipoContacto TipoContacto { get; set; }
}
