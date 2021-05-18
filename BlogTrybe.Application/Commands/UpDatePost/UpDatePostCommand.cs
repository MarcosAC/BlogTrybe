using MediatR;

namespace BlogTrybe.Application.Commands.UpDatePost
{
    public class UpDatePostCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
