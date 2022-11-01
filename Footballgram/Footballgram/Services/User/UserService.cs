namespace Footballgram.Services.User
{
    using Microsoft.AspNetCore.Http;
    using System.Security.Claims;

    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor httpContext;
        public UserService(IHttpContextAccessor httpContext)
        {
            this.httpContext = httpContext;
        }

        public string GetUserId() => httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
