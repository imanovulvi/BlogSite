using BlogSite.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Entity.DTOs.Category
{
    public class ResultCategoryDTO : BaseEntity
    {
        public string Name { get; set; }

    }
}
