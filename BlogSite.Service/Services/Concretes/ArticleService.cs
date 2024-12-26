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

    public async Task<List<ResultArticleDTO>> GetAllAsync(bool IsDelete)
    {

        var result = _mapper.Map<List<Article>, List<ResultArticleDTO>>(await _unitOfWork.Repository<Article>().GetAllAsync(x => x.IsDelete == IsDelete, x => x.Category));
        return result;
    }

    public async Task<ResultArticleDTO> GetByIdAsync(Guid id)
    {
        return _mapper.Map<Article, ResultArticleDTO>(await _unitOfWork.Repository<Article>().GetByIdAsync(id));


    }

    public async Task AddAsync(CreateArticleDTO createArticle)
    {
        await _unitOfWork.Repository<Article>().AddAsync(_mapper.Map<CreateArticleDTO, Article>(createArticle));
        await _unitOfWork.SaveAsync();
    }
    public async Task UpdateAsync(UpdateArticleDTO updateArticle)
    {
        await _unitOfWork.Repository<Article>().UpdateAsync(_mapper.Map<UpdateArticleDTO, Article>(updateArticle));
        await _unitOfWork.SaveAsync();
    }
    public async Task DeleteAsync(Guid id)
    {
        var article=await _unitOfWork.Repository<Article>().GetByIdAsync(id); 
        await _unitOfWork.Repository<Article>().DeleteAsync(article);
        await _unitOfWork.SaveAsync();
    }
}
