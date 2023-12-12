using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class ContactoPerDto : BaseEntity
{
    //public int Id { get; set; }

    public string Descripcion { get; set; }

    public int IdPersona { get; set; }

    public int IdTContacto { get; set; }

    public Persona Persona { get; set; }

    public TipoContacto TipoContacto { get; set; }
}
