using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class PersonaRepository : GenericRepository<Persona>, IPersona
{
    private readonly ApiContext _context;

    public PersonaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Persona>> GetAllAsync()
    {
        return await _context.Personas
            .ToListAsync();
    }

    public override async Task<Persona> GetByIdAsync(int id)
    {
        return await _context.Personas
        .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Persona>> GetEmpleados()
    {
        var result = await (
            from p in _context.Personas
            join t in _context.TipoPersonas on p.IdTpersona equals t.Id
            where t.Descripcion.ToLower() == "Empleado"
            select p
        ).ToListAsync();
        return result;
    }

    public async Task<IEnumerable<Persona>> GetVigilantes()
    {
        var result = await (
            from p in _context.Personas
            join c in _context.CategoriaPers on p.IdCat equals c.Id
            where c.NombreCat.ToLower() == "vigilante"
            select p
        ).ToListAsync();
        return result;
    }
}