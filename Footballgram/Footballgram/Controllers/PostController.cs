namespace Footballgram.Controllers
{
    using Footballgram.Infrastructure;
    using Footballgram.Models.Post;
    using Footballgram.Services.Post;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CreatePostFormModel model)
        {
            var created = postService.Create(model);

            return this.RedirectTo<HomeController>(c => c.Index());
        }
    }
}
