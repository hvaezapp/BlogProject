using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BlogProject.Application.Configuration
{
    public static class ConfigureService
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
