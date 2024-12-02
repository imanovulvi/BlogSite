using BlogSite.Core.BaseEntity;
using BlogSite.DataAccessLayer.Context;
using BlogSite.DataAccessLayer.Repository.Abstractions;
using BlogSite.DataAccessLayer.Repository.Concretes;


namespace BlogSite.DataAccessLayer.UnitOfWorkPattern;

public class UnitOfWork(BlogContext context) : IUnitOfWork
{

    public async ValueTask DisposeAsync()
        => await context.DisposeAsync();


    public IRepository<T> Repository<T>() where T : BaseEntity, new()
       => new Repository<T>(context);


    public int Save()
        => context.SaveChanges();


    public async Task<int> SaveAsync()
        => await context.SaveChangesAsync();

}
