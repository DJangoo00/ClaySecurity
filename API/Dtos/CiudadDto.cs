using System;
using System.Collections.Generic;
using Domain.Entities;
namespace API.Dtos;

public partial class CiudadDto : BaseEntity
{
    //public int Id { get; set; }

    public string NombreCiudad { get; set; }

    public int IdDepartamento { get; set; }

    public Departamento Departamento { get; set; }
}
