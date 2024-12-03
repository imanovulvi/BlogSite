using BlogSite.Entity.Entityes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System.Reflection;


namespace BlogSite.DataAccessLayer.Context
{
    public sealed class BlogContext:IdentityDbContext<AppUser,AppRole,Guid>
    {
  
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Identity ilə əlaqəli entitilər üçün əsas açarların düzgün təyin olunduğundan əmin olun
            modelBuilder.Entity<IdentityUserLogin<Guid>>().HasKey(x => new { x.LoginProvider, x.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserToken<Guid>>().HasKey(x => new { x.UserId, x.LoginProvider, x.Name });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());    
        }
    }
}
