namespace Footballgram.Services.Post
{
    using Footballgram.Data;
    using Footballgram.Data.Models;
    using Footballgram.Models.Post;
    using Footballgram.Services.User;
    using System.Threading.Tasks;

    public class PostService : IPostService
    {
        private readonly FootballgramDbContext _dbContext;
        private readonly IUserService userService;
        public PostService(FootballgramDbContext dbContext,
                           IUserService userService)
        {
            _dbContext = dbContext;
            this.userService = userService;
        }

        public async Task<bool> Create(CreatePostFormModel model)
        {
            var userId = this.userService.GetUserId();

            if (string.IsNullOrEmpty(model.ImageUrl)
                || string.IsNullOrEmpty(userId))
            {
                return false;
            }

            var post = new Post
            {
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                UserId = userId
            };

            await _dbContext.Posts.AddAsync(post);

            await _dbContext.SaveChangesAsync(); //TODO: Fix

            return true;
        }
    }
}
