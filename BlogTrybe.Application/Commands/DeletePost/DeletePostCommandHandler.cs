using BlogTrybe.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, Unit>
    {
        private readonly IPostRepository _postRepository;
        public DeletePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            await _postRepository.DeleteAsync(request.Id);

            await _postRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
