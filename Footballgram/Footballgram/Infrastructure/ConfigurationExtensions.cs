namespace Footballgram.Infrastructure
{
    using Microsoft.Extensions.Configuration;
    public static class ConfigurationExtensions
    {
        public static string GenerateKey(this IConfiguration configuration)
        {
            return configuration.GetConnectionString("DefaultConnection");
        }
    }
}
