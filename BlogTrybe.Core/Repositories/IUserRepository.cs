using BlogTrybe.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogTrybe.Core.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);   
        Task AddAsync(User user);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
    }
}
