using Domain.Entities;

namespace Domain.Interfaces;
public interface IContactoPer : IGenericRepository<ContactoPer>
{   
    Task<IEnumerable<object>> GetNumByEmp();
}