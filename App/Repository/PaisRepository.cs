using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly ApiContext _context;

    public PaisRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Pais>> GetAllAsync()
    {
        return await _context.Paises
            .ToListAsync();
    }

    public override async Task<Pais> GetByIdAsync(int id)
    {
        return await _context.Paises
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}