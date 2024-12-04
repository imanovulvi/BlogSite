using BlogSite.Entity.DTOs.AppUser;
using BlogSite.Entity.Entityes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogSite.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class AuthController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public AuthController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();

    }

    [HttpPost]
    public async Task<IActionResult> Login(UserLoginDTO user)
    {
        if (ModelState.IsValid)
        {
            var appUser = await _userManager.FindByEmailAsync(user.Email);
            if (appUser != null)
            {
                if (appUser.PasswordHash == user.Password)
                {
                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim("FullName",appUser.FullName),
                        new Claim("Id",appUser.Id.ToString())
                    };
                    ClaimsIdentity ci = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal cp = new ClaimsPrincipal(ci);
                    HttpContext.User = cp;

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, cp);

                    return Redirect("/Admin/Home/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Password yanlisdir");
                    return View("Index");
                }


            }
            else
            {
                ModelState.AddModelError("", "Email yanlisdir");
                return View("Index");
            }


        }
        else
            return View("Index");
    }
    public async Task<IActionResult> Logout(UserLoginDTO user)
    {
        return RedirectToAction("Home/Index");
    }
}
