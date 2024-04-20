using BlogSolution.Core.Entities;
using System.Linq.Expressions;

namespace BlogSolution.Core.Repositories;

public interface IBlogRepositories
{
    Task<Blog> GetAsync(int id);
    Task GetAllAsync(Expression<Func<bool,Blog>> expression = null, params string[] includes);
    Task InsertAsync(Blog blog);
    void Delete(int id);
    void SoftDelete(int id);
    Task CommitAsync();

}
