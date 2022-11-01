namespace Footballgram.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static ValidationConstants;
    public class Post
    {
        public int Id { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<Comment> Commnets { get; } = new HashSet<Comment>();
    }
}
