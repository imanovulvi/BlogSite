using BlogSite.Entity.Entityes;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccessLayer.EntityConfiguration
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(new IdentityUserRole<Guid>
            {
                RoleId= Guid.Parse("52061FEF-DD79-4A7A-AEEF-94FAD1F19047"),
                UserId= Guid.Parse("F4B33E74-60AE-4E55-8762-05B636AE0DA5")
            },
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("6C38AD42-985A-4A11-BEC8-D0D8D6C61A85"),
                UserId = Guid.Parse("72CA5EC3-35CA-4B66-B7F4-3630816C0717")
            }
            );
        }
    }
}
