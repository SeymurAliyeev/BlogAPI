using BlogSolution.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogSolution.Data.Configurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{

    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.Property(b => b.Title)
               .IsRequired()
               .HasMaxLength(500);

        builder.Property(b => b.Desc)
               .IsRequired()
               .HasMaxLength(1000);

    }
}
