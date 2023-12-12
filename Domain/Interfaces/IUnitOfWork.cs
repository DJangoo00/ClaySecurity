using Domain.Entities;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    //Main interfaces
    ICategoriaPer CategoriaPers { get; }
    ICiudad Ciudades { get; }
    IContactoPer ContactoPers { get; }
    IContrato Contratos { get; }
    IDepartamento Departamentos { get; }
    IDirPersona DirPersonas { get; }
    IEstado Estados { get; }
    IPais Paises { get; }
    IPersona Personas { get; }
    IProgramacion Programaciones { get; }
    ITipoContacto TipoContactos { get; }
    ITipoDireccion TipoDirecciones { get; }
    ITipoPersona TipoPersonas { get; }
    ITurno Turnos { get; }
    //JWT
    IUserRepository Users { get; }
    IRoleRepository Roles { get; }

    Task<int> SaveAsync();
}
