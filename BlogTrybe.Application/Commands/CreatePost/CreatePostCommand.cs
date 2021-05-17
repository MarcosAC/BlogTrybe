using MediatR;

namespace BlogTrybe.Application.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<int>
    {        
        public string Title { get; set; }
        public string Content { get; set; }
        public int IdUser { get; set; }
    }
}
