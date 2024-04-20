using BlogSolution.Core.Repositories;
using BlogSolution.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BlogSolution.Data;

public static class ServiceRegistration
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBlogRepositories, BlogRepository>();
    }
}
