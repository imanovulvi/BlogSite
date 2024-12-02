using AutoMapper;
using BlogSite.DataAccessLayer.UnitOfWorkPattern;
using BlogSite.Entity.DTOs.Article;
using BlogSite.Entity.Entityes;
using BlogSite.Service.Services.Abstractions;


namespace BlogSite.Service.Services.Concretes;

public class ArticleService : IArticleService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<ResultArticleDTO>> GetAllAsync()
    {

        var result = _mapper.Map<List<Article>, List<ResultArticleDTO>>(await _unitOfWork.Repository<Article>().GetAllAsync(x => x.IsDelete == false));
        return result;
    }

    public async Task<ResultArticleDTO> GetByIdAsync(Guid id)
    {
        return _mapper.Map<Article, ResultArticleDTO>(await _unitOfWork.Repository<Article>().GetByIdAsync(id));


    }
}
