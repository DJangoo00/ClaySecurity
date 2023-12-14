using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Persona : BaseEntity
{
    //public int Id { get; set; }

    public string IdPersona { get; set; }
    public string Nombre { get; set; }
    public DateOnly DateReg { get; set; }
    public int IdTpersona { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public int IdCat { get; set; }
    public CategoriaPer CategoriaPer { get; set; }
    public int IdCiudad { get; set; }
    public Ciudad Ciudad { get; set; }
    public ICollection<ContactoPer> ContactoPers { get; set; }
    public ICollection<Contrato> ContratoCliente { get; set; }
    public ICollection<Contrato> ContratoEmpleado { get; set; }
    public ICollection<DirPersona> DirPersonas { get; set; }
    public ICollection<Programacion> Programaciones { get; set; }
}
