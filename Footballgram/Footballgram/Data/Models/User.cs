namespace Footballgram.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        [Required]
        public string NickName { get; set; }

        public IEnumerable<Post> Posts { get; } = new HashSet<Post>();
        public IEnumerable<Comment> Comments { get; } = new HashSet<Comment>();
    }
}
