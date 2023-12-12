using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class DirPersonaDto : BaseEntity
{
    //public int Id { get; set; }

    public string Direccion { get; set; }

    public int IdPersona { get; set; }

    public int IdTDireccion { get; set; }

    public Persona Persona { get; set; }

    public TipoDireccion TipoDireccion { get; set; }
}
