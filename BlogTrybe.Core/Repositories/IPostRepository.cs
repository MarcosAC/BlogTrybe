using BlogTrybe.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogTrybe.Core.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(int id);
        Task<List<Post>> GetBySearchAsync(string searchTermTitle, string searchTermContent);
        Task AddAsync(Post post);
        Task DeleteAsync(int id);
        Task Update(Post post);
        Task SaveChangesAsync();
    }
}
