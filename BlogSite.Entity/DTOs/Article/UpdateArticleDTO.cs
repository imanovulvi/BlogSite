using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Entity.DTOs.Article
{
    public record UpdateArticleDTO(Guid Id,string Title, string Content, Guid CategoryId, Guid ImageId, Guid UserId)
    {

    }
}
