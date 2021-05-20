using BlogTrybe.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace BlogTrybe.Application.Queries.GetAllPostsBySearch
{
    public class GetAllPostsBySearchQuery : IRequest<List<PostsSearchViewModel>>
    {
        public GetAllPostsBySearchQuery(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public string Title { get; private set; }
        public string Content { get; private set; }
    }
}
