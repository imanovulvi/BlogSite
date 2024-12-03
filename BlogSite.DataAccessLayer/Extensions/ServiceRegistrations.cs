using BlogSite.DataAccessLayer.Context;
using BlogSite.DataAccessLayer.Repository.Abstractions;
using BlogSite.DataAccessLayer.Repository.Concretes;
using BlogSite.DataAccessLayer.UnitOfWorkPattern;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System;
using BlogSite.Entity.Entityes;


namespace BlogSite.DataAccessLayer.Extensions;

public static class ServiceRegistrations
{
    public static IServiceCollection AddDALService(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<BlogContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("DefaultCon")));


        _ = services.AddIdentityCore<AppUser>(x =>
        {
            x.Password.RequireUppercase = false;
            x.Password.RequireUppercase = false;
            x.Password.RequireNonAlphanumeric = false;
            x.Password.RequireLowercase = false;
        }
        ).AddRoles<AppRole>().AddEntityFrameworkStores<BlogContext>();


        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        return services;
    }
}
