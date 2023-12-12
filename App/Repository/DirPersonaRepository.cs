using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class DirPersonaRepository : GenericRepository<DirPersona>, IDirPersona
{
    private readonly ApiContext _context;

    public DirPersonaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<DirPersona>> GetAllAsync()
    {
        return await _context.DirPersonas
            .ToListAsync();
    }

    public override async Task<DirPersona> GetByIdAsync(int id)
    {
        return await _context.DirPersonas
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}