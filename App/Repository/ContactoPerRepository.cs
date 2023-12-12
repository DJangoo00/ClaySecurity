using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace App.Repository;
public class ContactoPerRepository : GenericRepository<ContactoPer>, IContactoPer
{
    private readonly ApiContext _context;

    public ContactoPerRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<ContactoPer>> GetAllAsync()
    {
        return await _context.ContactoPers
            .ToListAsync();
    }

    public override async Task<ContactoPer> GetByIdAsync(int id)
    {
        return await _context.ContactoPers
        .FirstOrDefaultAsync(p => p.Id == id);
    }
}