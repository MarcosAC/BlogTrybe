using MediatR;

namespace BlogTrybe.Application.Commands.CreatUser
{
    public class CreatUserCommand : IRequest<int>
    {
        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Image { get; private set; }
    }
}
