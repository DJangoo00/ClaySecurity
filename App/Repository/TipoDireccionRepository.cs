using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class TipoDireccionRepository : GenericRepository<TipoDireccion>, ITipoDireccion
{
    private readonly ApiContext _context;

    public TipoDireccionRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<TipoDireccion>> GetAllAsync()
    {
        return await _context.TipoDirecciones
            .ToListAsync();
    }

    public override async Task<TipoDireccion> GetByIdAsync(int id)
    {
        return await _context.TipoDirecciones
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}