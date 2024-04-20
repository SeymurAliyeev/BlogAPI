using BlogSolution.Business.Services.Implementations;
using BlogSolution.Business.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlogSolution.Business;

public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBlogServices, BlogService>();
    }
}
