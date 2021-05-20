using BlogTrybe.Application.Commands.CreatePost;
using BlogTrybe.Application.Commands.DeletePost;
using BlogTrybe.Application.Commands.UpDatePost;
using BlogTrybe.Application.Queries.GetAllPosts;
using BlogTrybe.Application.Queries.GetPostById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogTrybe.API.Controllers
{
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePostCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id}, command);
        }

        [HttpGet("{search}")]
        public async Task<IActionResult> Search(string searchTerm)
        {            
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetPostByIdQuery(id);

            var post = await _mediator.Send(query);

            if (post == null)
                return NotFound();

            return Ok(post);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpDatePostCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var getAllPostQuery = new GetAllPostsQuery(query);

            var posts = await _mediator.Send(getAllPostQuery);

            return Ok(posts);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeletePostCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
