using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class ContratoRepository : GenericRepository<Contrato>, IContrato
{
    private readonly ApiContext _context;

    public ContratoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Contrato>> GetAllAsync()
    {
        return await _context.Contratos
            .ToListAsync();
    }

    public override async Task<Contrato> GetByIdAsync(int id)
    {
        return await _context.Contratos
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}