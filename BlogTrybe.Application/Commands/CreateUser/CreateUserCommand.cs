using MediatR;

namespace BlogTrybe.Application.Commands.CreatUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
    }
}
