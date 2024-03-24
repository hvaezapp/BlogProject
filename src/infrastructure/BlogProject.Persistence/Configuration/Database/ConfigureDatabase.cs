using BlogProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogProject.Persistence.Configuration.Database
{
    public static class ConfigureDatabase
    {
        public static void ConfigureAppDatabase(this IServiceCollection services,
                                                  IConfiguration configuration)
        {

            // Introduce Db to EF-Core
            services.AddDbContext<BlogDB>(s =>
            {
                s.UseSqlServer(configuration.GetConnectionString("SqlSever"));
            });

        }
    }
}
