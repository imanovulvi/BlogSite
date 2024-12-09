using BlogSite.Entity.DTOs.Article;
using BlogSite.Service.Services.Abstractions;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogSite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;

        public HomeController(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllAsync(false);
            return View(articles);
        }


        public async Task<IActionResult> Add()
        {
            var categorys = await _categoryService.GetAllAsync(false);
            return View(categorys);
        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateArticleDTO createArticle)
        {
            createArticle.ImageId = Guid.Parse("721aa18c-3817-4f2f-a9d8-40be9d5b52cc");
            createArticle.UserId = Guid.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value);
            await _articleService.AddAsync(createArticle);
            return Redirect("index");
        }
    }
}
