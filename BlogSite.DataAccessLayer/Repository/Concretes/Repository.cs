using BlogSite.Core.BaseEntity;
using BlogSite.DataAccessLayer.Context;
using BlogSite.DataAccessLayer.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogSite.DataAccessLayer.Repository.Concretes;

public class Repository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly BlogContext _context;

    public Repository(BlogContext context)
    => _context = context;

    public DbSet<T> Table { get => _context.Set<T>(); }
    public async Task<bool> AddAsync(T entity)
    {
        await Table.AddAsync(entity);
        return true;
    }

    public async Task<bool> DeleteAsync(T entity)
    {
        await Task.Run(() => Table.Remove(entity));
        return true;
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = Table;
        if (predicate is not null)
            query = query.Where(predicate);
        if (includes.Any())
            foreach (var item in includes)
                query = query.Include(item);

        return await query.ToListAsync();

    }

    public async Task<T> GetByIdAsync(Guid id)
        => await Table.FirstOrDefaultAsync(x => x.Id == id);
    

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = Table;
        if (predicate is not null)
            query = query.Where(predicate);
        if (includes.Any())
            foreach (var item in includes)
                query = query.Include(item);

        return await query.SingleAsync();
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        await Task.Run(() => Table.Update(entity));
        return true;
    }
}
