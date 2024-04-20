using BlogSolution.Core.Entities;
using BlogSolution.Core.Repositories;
using BlogSolution.Data.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogSolution.Data.Repository;

public class BlogRepository : IBlogRepositories
{
    private readonly Context _context;

    public BlogRepository(Context context)
    {
        _context = context;
    }
    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task InsertAsync(Blog blog)
    {
        if(blog is null)
        {
            throw new ArgumentNullException(nameof(blog));
        }
        Blog _blog = new Blog()
        {
            Title = blog.Title,
            Desc = blog.Desc,
            IsDeleted = false,
            CreatedDate = blog.CreatedDate,
            UpdatedDate = blog.UpdatedDate
        };
        await _context.AddAsync(_blog);
        await _context.SaveChangesAsync();
    }

    public void Delete(int id)
    {
        if(_context.Blogs.Any(b => b.Id != id))
        {
            throw new Exception("Blog is not found!");
        }

        var blog = _context.Blogs.Find(id);
        _context.Blogs.Remove(blog);
        _context.SaveChanges();
    }

    public async Task GetAllAsync(Expression<Func<bool, Blog>> expression = null, params string[] includes)
    {
    }

    public async Task<Blog> GetAsync(int id)
    {
        if(await _context.Blogs.AnyAsync(b => b.Id != id))
        {
            throw new Exception("Blog is not found");
        }

        var blog = await _context.Blogs.FindAsync(id);
        return blog;
    }

    public void SoftDelete(int id)
    {
        var blog = _context.Blogs.Find(id);
        blog.IsDeleted = true;
        _context.SaveChanges();
    }
}
