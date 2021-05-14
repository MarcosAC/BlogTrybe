using BlogTrybe.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlogTrybe.Infrastructure.Persistence
{
    public class BlogTrybeDbContext : DbContext
    {
        public BlogTrybeDbContext(DbContextOptions<BlogTrybeDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
