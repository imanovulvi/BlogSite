using BlogSite.Core.BaseEntity;
using BlogSite.Entity.DTOs.Category;
using BlogSite.Entity.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogSite.Entity.DTOs.Article
{
    using BlogSite.Entity.Entityes;
    public class ResultArticleDTO : BaseEntity
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }

        public ResultCategoryDTO Category { get; set; }
        public Guid ImageId { get; set; }
    }
}