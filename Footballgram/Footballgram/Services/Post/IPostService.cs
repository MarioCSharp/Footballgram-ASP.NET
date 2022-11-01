namespace Footballgram.Services.Post
{
    using Footballgram.Models.Post;
    using System.Threading.Tasks;

    public interface IPostService
    {
        Task<bool> Create(CreatePostFormModel model);
    }
}
