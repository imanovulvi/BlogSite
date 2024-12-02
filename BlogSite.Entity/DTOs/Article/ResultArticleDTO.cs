using BlogSite.Core.BaseEntity;
using BlogSite.Entity.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Entity.DTOs.Article;

public class ResultArticleDTO:BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public Guid CategoryId { get; set; }
    public Guid ImageId { get; set; }
}
