using BlogTrybe.Application.ViewModels;
using BlogTrybe.Core.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlogTrybe.Application.Queries.GetAllPosts
{
    public class GetAllPostsQueryHandler : IRequestHandler<GetAllPostsQuery, List<PostViewModel>>
    {
        private readonly IPostRepository _postRepository;

        public GetAllPostsQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostViewModel>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAllAsync();

            var postsViewModel = posts
                .Select(post => new PostViewModel(
                    post.Id, 
                    post.Title,
                    post.Content,
                    post.Published))
                .ToList();

            return postsViewModel;
        }
    }
}
