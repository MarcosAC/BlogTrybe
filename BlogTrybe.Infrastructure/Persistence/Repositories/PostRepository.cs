using BlogTrybe.Core.Entities;
using BlogTrybe.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogTrybe.Infrastructure.Persistence.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogTrybeDbContext _dbContext;

        public PostRepository(BlogTrybeDbContext dbContext)
        {
            _dbContext = dbContext;
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
