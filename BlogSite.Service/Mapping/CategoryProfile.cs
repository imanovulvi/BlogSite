using AutoMapper;
using BlogSite.Entity.DTOs.Category;
using BlogSite.Entity.Entityes;


namespace BlogSite.Service.Mapping
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, ResultCategoryDTO>().ReverseMap();
        }

    }
}
