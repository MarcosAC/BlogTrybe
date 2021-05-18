using MediatR;

namespace BlogTrybe.Application.Commands.DeletePost
{
    public class DeletePostCommand : IRequest<Unit>
    {
        public DeletePostCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
