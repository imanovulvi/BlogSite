using BlogSite.Entity.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.Services.Abstractions
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDTO>> GetAllAsync(bool IsDelete);
    }
}
