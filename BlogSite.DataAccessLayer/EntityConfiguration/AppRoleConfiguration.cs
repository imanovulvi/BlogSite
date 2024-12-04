using BlogSite.Entity.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccessLayer.EntityConfiguration
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole
                {
                    Id=Guid.Parse("52061FEF-DD79-4A7A-AEEF-94FAD1F19047"),
                    Name="Admin",
                    NormalizedName="ADMIN"
                },
                 new AppRole
                 {
                     Id = Guid.Parse("6C38AD42-985A-4A11-BEC8-D0D8D6C61A85"),
                     Name = "User",
                     NormalizedName = "USER"
                 }
                );
        }
    }
}
