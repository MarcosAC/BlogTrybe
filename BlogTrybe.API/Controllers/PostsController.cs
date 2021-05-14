using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTrybe.API.Controllers
{
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        public PostsController()
        {

        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Search(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id)
        {
            return NoContent();
        }

        [HttpGet("{search}")]
        public async Task<IActionResult> Get(string search)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return NoContent();
        }
    }
}
