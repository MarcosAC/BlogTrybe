using BlogTrybe.Core.Entities;
using BlogTrybe.Infrastructure.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Commands.CreatUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly BlogTrybeDbContext _dbContext;

        public CreateUserCommandHandler(BlogTrybeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(
                request.DisplayName,
                request.Email,
                request.Password,
                request.Image);

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user.Id;
        }
    }
}
