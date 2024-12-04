using BlogSite.Entity.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccessLayer.EntityConfiguration;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.HasData(
            new AppUser
            {
                Id = Guid.Parse("F4B33E74-60AE-4E55-8762-05B636AE0DA5"),
                FullName = "ULvi Imanov",
                Email = "imanov@gmail.com",
                PasswordHash = "1234",
                UserName = "Ulvi",
                EmailConfirmed = true
            },
            new AppUser
            {
                Id = Guid.Parse("72CA5EC3-35CA-4B66-B7F4-3630816C0717"),
                FullName = "Terlan Imanov",
                Email = "ter@gmail.com",
                PasswordHash = "1234",
                UserName = "Terlan",
                EmailConfirmed = true
            }
            );
    }
}
