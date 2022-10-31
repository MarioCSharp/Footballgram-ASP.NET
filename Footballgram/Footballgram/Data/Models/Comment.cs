namespace Footballgram.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static ValidationConstants;
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
