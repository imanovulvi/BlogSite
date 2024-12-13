using BlogSite.DataAccessLayer.Context;
using BlogSite.DataAccessLayer.Extensions;
using Microsoft.EntityFrameworkCore;
using BlogSite.Service.Extensions;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDALService(builder.Configuration);
builder.Services.AddService();

builder.Services.AddAuthentication("Cookies")
    .AddCookie("Cookies", options =>
    {

        options.LoginPath = "/admin/auth/index";
        options.LogoutPath = "/admin/auth/logout";
        options.Cookie.Name = "MyAuthCookie";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
