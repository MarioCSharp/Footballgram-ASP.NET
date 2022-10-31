namespace Footballgram.Data
{
    using Footballgram.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class FootballgramDbContext : IdentityDbContext<User>
    {
        public FootballgramDbContext(DbContextOptions<FootballgramDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) // TODO: 
        {
            base.OnModelCreating(builder);
        }
    }
}
