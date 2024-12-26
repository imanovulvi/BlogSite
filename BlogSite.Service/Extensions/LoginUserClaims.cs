using System.Security.Claims;

namespace BlogSite.Service.Extensions;

public static class LoginUserClaims
{
    public static string GetUserId(this ClaimsPrincipal claimsPrincipal)
    {
        return claimsPrincipal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
    }
    public static string GetUserEmail(this ClaimsPrincipal claimsPrincipal)
    {
        return claimsPrincipal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email).Value;
    }
}
