using AutoMapper;
using BlogSite.Entity.DTOs.Article;
using BlogSite.Entity.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.Mapping
{
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article,ResultArticleDTO>().ReverseMap();
            CreateMap<Article,CreateArticleDTO>().ReverseMap();
        }
    }
}
