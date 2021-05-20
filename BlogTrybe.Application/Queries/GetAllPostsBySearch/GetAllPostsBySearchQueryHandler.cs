using BlogTrybe.Application.ViewModels;
using BlogTrybe.Core.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Queries.GetAllPostsBySearch
{
    class GetAllPostsBySearchQueryHandler : IRequestHandler<GetAllPostsBySearchQuery, List<PostsSearchViewModel>>
    {
        private readonly IPostRepository _postRepository;

        public GetAllPostsBySearchQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostsSearchViewModel>> Handle(GetAllPostsBySearchQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetBySearchAsync(request.Title, request.Content);

            var postsSearchViewModel = posts
                .Select(post => new PostsSearchViewModel(
                    post.Id,
                    post.Published,
                    post.UpDate,
                    post.Title,
                    post.Content,
                    post.IdUser,
                    post.User.DisplayName,
                    post.User.Email,
                    post.User.Image))
                .ToList();

            return postsSearchViewModel;
        }
    }
}
