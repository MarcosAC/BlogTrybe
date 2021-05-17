using BlogTrybe.Core.Entities;
using BlogTrybe.Infrastructure.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly BlogTrybeDbContext _dbContext;

        public CreatePostCommandHandler(BlogTrybeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post(
                request.Title,
                request.Content,
                request.IdUser) ;

            await _dbContext.Posts.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return post.Id;
        }
    }
}
