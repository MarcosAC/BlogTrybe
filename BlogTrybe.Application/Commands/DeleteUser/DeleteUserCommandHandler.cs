using BlogTrybe.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            await _userRepository.DeleteAsync(request.Id);

            await _userRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
