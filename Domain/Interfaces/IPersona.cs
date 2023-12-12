using Domain.Entities;

namespace Domain.Interfaces;
public interface IPersona : IGenericRepository<Persona>
{   
    Task<IEnumerable<Persona>> GetEmpleados();
    Task<IEnumerable<Persona>> GetVigilantes();
}