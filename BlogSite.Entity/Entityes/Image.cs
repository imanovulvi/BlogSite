using BlogSite.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Entity.Entityes
{
    public class Image:BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }

        [NotMapped]
        public override string? ModifyBy { get; set; }

        [NotMapped]
        public override DateTime? ModifyDate { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
