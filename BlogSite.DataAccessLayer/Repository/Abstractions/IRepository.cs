using BlogSite.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccessLayer.Repository.Abstractions
{
    public interface IRepository<T> where T : IBaseEntity,new()
    {
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null,params Expression<Func<T,bool>>[] include);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, bool>>[] include);
        Task<T> GetByIdAsync(Guid id);

        Task<bool> AddAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> UpdateAsync(T entity);

    }
}
