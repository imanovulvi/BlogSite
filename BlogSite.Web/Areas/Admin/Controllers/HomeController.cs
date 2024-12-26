using BlogSite.Entity.DTOs.Article;
using BlogSite.Service.Services.Abstractions;
using BlogSite.Service.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;

namespace BlogSite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IToastNotification _toastNotification;

        public HomeController(IArticleService articleService, ICategoryService categoryService,IToastNotification toastNotification)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _toastNotification = toastNotification;
        }
        [HttpGet]
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
            createArticle.UserId = Guid.Parse(HttpContext.User.GetUserId());
            await _articleService.AddAsync(createArticle);
            _toastNotification.AddSuccessToastMessage("əlavə olundu");
            return Redirect("index");
        }
        [HttpGet]
        public async Task<IActionResult> GetUpdate(Guid id)
        {
            string qid = HttpContext.Request.Query["id"].ToString();
            var article = await _articleService.GetByIdAsync(id);
            var categorys = await _categoryService.GetAllAsync(false);
            ViewBag.Categorys = categorys;
            return View(article);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateArticleDTO updateArticle)
        {
            UpdateArticleDTO updateArticle2 = updateArticle with { UserId = Guid.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value), ImageId = Guid.Parse("721aa18c-3817-4f2f-a9d8-40be9d5b52cc") };
            if (ModelState.IsValid)
                await _articleService.UpdateAsync(updateArticle2);

            string qid = HttpContext.Request.Query["id"].ToString();


            return Redirect("GetUpdate?id=05faa4b6-8935-4acb-88f9-9df35579a25e");
        }


        public async Task<IActionResult> Delete([FromQuery] Guid id)
        {
            await _articleService.DeleteAsync(id);
            return Redirect("index");
        }
    }
}
