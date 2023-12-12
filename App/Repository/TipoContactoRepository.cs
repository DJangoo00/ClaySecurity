using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class TipoContactoRepository : GenericRepository<TipoContacto>, ITipoContacto
{
    private readonly ApiContext _context;

    public TipoContactoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<TipoContacto>> GetAllAsync()
    {
        return await _context.TipoContactos
            .ToListAsync();
    }

    public override async Task<TipoContacto> GetByIdAsync(int id)
    {
        return await _context.TipoContactos
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}