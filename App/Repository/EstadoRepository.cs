using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class EstadoRepository : GenericRepository<Estado>, IEstado
{
    private readonly ApiContext _context;

    public EstadoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Estado>> GetAllAsync()
    {
        return await _context.Estados
            .ToListAsync();
    }

    public override async Task<Estado> GetByIdAsync(int id)
    {
        return await _context.Estados
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}