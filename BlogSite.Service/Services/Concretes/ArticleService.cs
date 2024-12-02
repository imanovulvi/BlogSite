using BlogSite.DataAccessLayer.UnitOfWorkPattern;
using BlogSite.Entity.Entityes;
using BlogSite.Service.Services.Abstractions;


namespace BlogSite.Service.Services.Concretes;

public class ArticleService : IArticleService
{
    private readonly IUnitOfWork _unitOfWork;

    public ArticleService(IUnitOfWork unitOfWork)
       => _unitOfWork = unitOfWork;
    
    public Task<List<Article>> GetAllAsync()
    {
  
        return _unitOfWork.Repository<Article>().GetAllAsync(x => x.IsDelete == false);
    }

    public async Task<Article> GetByIdAsync(Guid id)
    {
      return  await _unitOfWork.Repository<Article>().GetByIdAsync(id);
    }
}
