using BlogSolution.Business.DTOs.BlogDTOs;
using BlogSolution.Core.Entities;
using System.Linq.Expressions;

namespace BlogSolution.Business.Services.Interfaces;

public interface IBlogServices
{
    Task GetOneById(int id);
    Task ShowAllAsync(Expression<Func<bool, Blog>> expression = null, params string[] includes);
    Task CreateAsync(Blog blog);
    void Delete(int id);
    void SoftDelete(int id);
    void Update(int id);
}
