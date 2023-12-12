using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class ProgramacionRepository : GenericRepository<Programacion>, IProgramacion
{
    private readonly ApiContext _context;

    public ProgramacionRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Programacion>> GetAllAsync()
    {
        return await _context.Programaciones
            .ToListAsync();
    }

    public override async Task<Programacion> GetByIdAsync(int id)
    {
        return await _context.Programaciones
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}