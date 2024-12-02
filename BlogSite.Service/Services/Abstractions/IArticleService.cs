using BlogSite.Entity.DTOs.Article;
using BlogSite.Entity.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ResultArticleDTO>> GetAllAsync();
        Task<ResultArticleDTO> GetByIdAsync(Guid id);
    }
}
