using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class CategoriaPerRepository : GenericRepository<CategoriaPer>, ICategoriaPer
{
    private readonly ApiContext _context;

    public CategoriaPerRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<CategoriaPer>> GetAllAsync()
    {
        return await _context.CategoriaPers
            .ToListAsync();
    }

    public override async Task<CategoriaPer> GetByIdAsync(int id)
    {
        return await _context.CategoriaPers
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}