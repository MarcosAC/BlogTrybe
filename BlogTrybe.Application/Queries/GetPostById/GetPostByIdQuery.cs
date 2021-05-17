using BlogTrybe.Application.ViewModels;
using MediatR;

namespace BlogTrybe.Application.Queries.GetPostById
{
    public class GetPostByIdQuery : IRequest<PostViewModel>
    {
        public GetPostByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
