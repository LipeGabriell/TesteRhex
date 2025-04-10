using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TesteRhex.Contexts;

namespace TesteRhexAPI.Repositories;

public class BaseRepository<T>(ApplicationDbContext context) : IBaseRepository<T> where T : class
{
    public async Task<T?> Get(Expression<Func<T, bool>> predicate)
    {
        return await context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
    }

    public async Task<T?> GetById(int id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>?> GetAll()
    {
        return await context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T?> Create(T model)
    {
        var added = await context.Set<T>().AddAsync(model);
        await context.SaveChangesAsync();
        return added.Entity;
    }

    public async Task<T?> Update(T model)
    {
        context.Set<T>().Update(model);
        await context.SaveChangesAsync();
        return model;
    }

    public async Task<T?> Delete(T model)
    {
        context.Set<T>().Remove(model);
        await context.SaveChangesAsync();
        return model;
    }
}