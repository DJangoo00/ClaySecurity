using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class PersonaDto : BaseEntity
{
    //public int Id { get; set; }
    public string IdPersona { get; set; }
    public string Nombre { get; set; }
    public DateOnly DateReg { get; set; }
    public int IdTpersona { get; set; }
    public int IdCat { get; set; }
    public int IdCiudad { get; set; }
    public CategoriaPer CategoriaPer { get; set; }
    public Ciudad Ciudad { get; set; }
    public TipoPersona TipoPersona { get; set; }

}
