using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.BaseEntity
{
    public abstract class BaseEntity : IBaseEntity
    {
        protected BaseEntity()
        {
            CreateDate = DateTime.Now;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public virtual string CreateBy { get; set; } = "test";
        public virtual DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual string? ModifyBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual bool IsDelete { get; set; }
    }
}
