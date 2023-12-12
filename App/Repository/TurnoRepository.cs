using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class TurnoRepository : GenericRepository<Turno>, ITurno
{
    private readonly ApiContext _context;

    public TurnoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Turno>> GetAllAsync()
    {
        return await _context.Turnos
            .ToListAsync();
    }

    public override async Task<Turno> GetByIdAsync(int id)
    {
        return await _context.Turnos
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}