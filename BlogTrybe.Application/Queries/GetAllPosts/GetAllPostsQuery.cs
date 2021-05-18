using BlogTrybe.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace BlogTrybe.Application.Queries.GetAllPosts
{
    public class GetAllPostsQuery : IRequest<List<PostViewModel>>
    {
        public GetAllPostsQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
