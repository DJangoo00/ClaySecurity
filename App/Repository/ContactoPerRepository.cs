using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class ContactoPerRepository : GenericRepository<ContactoPer>, IContactoPer
{
    private readonly ApiContext _context;

    public ContactoPerRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<ContactoPer>> GetAllAsync()
    {
        return await _context.ContactoPers
            .ToListAsync();
    }

    public override async Task<ContactoPer> GetByIdAsync(int id)
    {
        return await _context.ContactoPers
        .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<object>> GetNumByEmp()
{
    var result = await (
        from p in _context.Personas
        join t in _context.TipoPersonas on p.IdTpersona equals t.Id
        where t.Descripcion.ToLower() == "empleado"
        select new
        {
            Empleado = p.Nombre,
            IdPersona = p.IdPersona,
            Contactos = (
                from c in _context.ContactoPers
                where c.IdPersona == p.Id
                select new { Contacto = c.Descripcion }
            ).ToList()
        }
    ).ToListAsync();

    return result;
}

}