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
        Task<List<Article>> GetAllAsync();
        Task<Article> GetByIdAsync(Guid id);
    }
}
