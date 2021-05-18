using BlogTrybe.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Commands.UpDatePost
{
    public class UpDatePostCommandHandler : IRequestHandler<UpDatePostCommand, Unit>
    {
        private readonly IPostRepository _postRepository;

        public UpDatePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Unit> Handle(UpDatePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetByIdAsync(request.Id);

            post.Update(request.Title, request.Content);

            await _postRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
