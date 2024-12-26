using BlogSite.Core.BaseEntity;
using System.Linq.Expressions;

namespace BlogSite.DataAccessLayer.Repository.Abstractions;

public interface IRepository<T> where T : IBaseEntity,new()
{

    Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null,params Expression<Func<T,object>>[] include);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] include);
    Task<T> GetByIdAsync(Guid id);

    Task<bool> AddAsync(T entity);
    Task<bool> DeleteAsync(T entity);
    Task<bool> UpdateAsync(T entity);

}


