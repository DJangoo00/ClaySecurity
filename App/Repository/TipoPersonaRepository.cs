using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersona
{
    private readonly ApiContext _context;

    public TipoPersonaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<TipoPersona>> GetAllAsync()
    {
        return await _context.TipoPersonas
            .ToListAsync();
    }

    public override async Task<TipoPersona> GetByIdAsync(int id)
    {
        return await _context.TipoPersonas
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}