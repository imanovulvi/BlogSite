using AutoMapper;
using BlogSite.DataAccessLayer.Repository.Abstractions;
using BlogSite.DataAccessLayer.UnitOfWorkPattern;
using BlogSite.Entity.DTOs.Category;
using BlogSite.Entity.Entityes;
using BlogSite.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<ResultCategoryDTO>> GetAllAsync(bool IsDelete)
        {
            var categorys = await _unitOfWork.Repository<Category>().GetAllAsync(x => x.IsDelete == IsDelete);
            return _mapper.Map<List<Category>, List<ResultCategoryDTO>>(categorys);
        }
    }
}
