using br.com.toodoo.core.FormAggregate;
using br.com.toodoo.core.Interfaces.Infrastructure;
using br.com.toodoo.infrastructure.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace br.com.toodoo.infrastructure.Repositories;

public class FormRepository : BaseRepository<Form>, IFormRepository
{
    public FormRepository(DatabaseContext context)
        : base(context)
    {
    }

    public async Task<Form> GetFormField(long id)
    {
        return await DatabaseContext.Forms.AsNoTracking()
            .Include(f => f.Fields)
            .FirstOrDefaultAsync(f => f.Id == id);
    }
}