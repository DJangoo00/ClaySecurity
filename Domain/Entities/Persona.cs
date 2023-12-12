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

    public int IdCat { get; set; }

    public int IdCiudad { get; set; }

    public virtual ICollection<ContactoPer> ContactoPers { get; set; }

    public virtual ICollection<Contrato> ContratoIdClienteNavigations { get; set; }

    public virtual ICollection<Contrato> ContratoIdEmpleadoNavigations { get; set; }

    public virtual ICollection<DirPersona> Dirpersonas { get; set; }

    public virtual CategoriaPer CategoriaPer { get; set; }

    public virtual Ciudad Ciudad { get; set; }

    public virtual TipoPersona TipoPersona { get; set; }

    public virtual ICollection<Programacion> Programaciones { get; set; }
}
