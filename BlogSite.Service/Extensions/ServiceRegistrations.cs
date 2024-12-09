using BlogSite.Service.Services.Abstractions;
using BlogSite.Service.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.Extensions
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {

            var asm = Assembly.GetExecutingAssembly();

            services.AddAutoMapper(asm);
            services.AddScoped(typeof(IArticleService), typeof(ArticleService));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            return services;
        }

      
    }
}
