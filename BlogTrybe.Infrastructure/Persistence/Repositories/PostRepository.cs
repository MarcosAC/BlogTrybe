using BlogTrybe.Core.Entities;
using BlogTrybe.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogTrybe.Infrastructure.Persistence.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogTrybeDbContext _dbContext;
        private readonly string _connectionString;

        public PostRepository(BlogTrybeDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }

        public async Task AddAsync(Post post)
        {
            await _dbContext.Posts.AddAsync(post);
            await SaveChangesAsync();
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await _dbContext.Posts.ToListAsync();
        }

        public async Task<Post> GetByIdAsync(int id)
        {
            return await _dbContext.Posts
                .SingleOrDefaultAsync(post => post.Id == id);
        }

        public async Task<List<Post>> GetBySearchAsync(string searchTermTitle, string searchTermContent)
        {
            var posts = await _dbContext.Posts
                .Include(post => post.User)
                .ToListAsync();

            if (!string.IsNullOrEmpty(searchTermTitle))
                return posts.FindAll(post => post.Title == searchTermTitle);
            else if (!string.IsNullOrEmpty(searchTermContent))
                return posts.FindAll(post => post.Content == searchTermContent);

            return null;
        }

        public Task Update(Post post)
        {
            //using (var sqlConnection = new SqlConnection(_connectionString))
            //{
            //    sqlConnection.Open();

            //    var script = "UPDATE Posts SET Title = @title, Content = @content WHERE Id = @id";

            //    await sqlConnection.ExecuteAsync(script, new { title = post.Title, content = post.Content, post.Id });
            //}
            throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var post = await GetByIdAsync(id);

            _dbContext.Posts.Remove(post);

            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }        
    }
}
