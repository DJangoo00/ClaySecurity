using System;
using System.Collections.Generic;
using Domain.Entities;

namespace API.Dtos;

public partial class PaisDto : BaseEntity
{
    //public int Id { get; set; }
    public string NombrePais { get; set; }
}
