using BlogSite.Core.BaseEntity;
using BlogSite.DataAccessLayer.Context;
using BlogSite.DataAccessLayer.Repository.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccessLayer.Repository.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly BlogContext _context;

        public Repository(BlogContext context)
        {
            _context = context;
        }
        public DbSet<T> Table { get => _context.Set<T>(); }
        public async Task<bool> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            return true;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            Task.Run(() => Table.Remove(entity));
            return true;
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, bool>>[] includes)
        {
            IQueryable<T> query = Table;
            if (predicate is not null)
                query = query.Where(predicate);
            if (includes.Any())
                foreach (var item in includes)
                    query = query.Include(item);

          return  await query.ToListAsync();

        }

        public async Task<T> GetByIdAsync(Guid id)
        {
         return  await Table.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, bool>>[] includes)
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
           Task.Run(()=>Table.Update(entity));
            return true;
        }
    }
}
