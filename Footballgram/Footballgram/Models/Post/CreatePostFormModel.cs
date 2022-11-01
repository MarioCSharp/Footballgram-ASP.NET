namespace Footballgram.Models.Post
{
    using System.ComponentModel.DataAnnotations;
    using static Footballgram.Data.ValidationConstants;
    public class CreatePostFormModel
    {
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}
