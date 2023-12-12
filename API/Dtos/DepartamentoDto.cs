using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class DepartamentoDto : BaseEntity
{
    //public int Id { get; set; }

    public string NombreDepartamento { get; set; }
    public int IdPais { get; set; }
    public Pais Pais { get; set; }
}
