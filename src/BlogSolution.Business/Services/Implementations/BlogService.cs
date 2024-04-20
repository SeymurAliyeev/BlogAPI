using BlogSolution.Business.Services.Interfaces;
using BlogSolution.Core.Entities;
using BlogSolution.Core.Repositories;
using System.Linq.Expressions;

namespace BlogSolution.Business.Services.Implementations;

public class BlogService : IBlogServices
{
    private readonly IBlogRepositories _blogRepositories;

    public BlogService(IBlogRepositories blogRepositories)
    {
        _blogRepositories = blogRepositories;
    }
    public async Task CreateAsync(Blog blog)
    {
        _blogRepositories.InsertAsync(blog);

    }

    public void Delete(int id)
    {
        _blogRepositories.Delete(id);
    }

    public async Task GetOneById(int id)
    {
        _blogRepositories.GetAsync(id);
    }

    public Task ShowAllAsync(Expression<Func<bool, Blog>> expression = null, params string[] includes)
    {
        throw new NotImplementedException();
    }

    public void SoftDelete(int id)
    {
        _blogRepositories.SoftDelete(id);
    }

    public void Update(int id)
    {
    }
}
