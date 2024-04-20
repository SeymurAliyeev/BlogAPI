using BlogSolution.Core.Entities;
using BlogSolution.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BlogSolution.Data.AppDbContext;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options) {}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Blog> Blogs { get; set; }
}
