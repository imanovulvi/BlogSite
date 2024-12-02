using BlogSite.Core.BaseEntity;
using BlogSite.DataAccessLayer.Repository.Abstractions;


namespace BlogSite.DataAccessLayer.UnitOfWorkPattern
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IRepository<T> Repository<T>() where T : BaseEntity,new();

        int Save();
        Task<int> SaveAsync();
    }
}
