using BlogTrybe.Application.ViewModels;
using BlogTrybe.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserViewModel>
    {
        private readonly BlogTrybeDbContext _dbContext;

        public GetUserQueryHandler(BlogTrybeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(user => user.Id == request.Id);

            if (user == null)
                return null;

            return new UserViewModel(user.DisplayName, user.Email, user.Image);
        }
    }
}
