using Microsoft.AspNetCore.Mvc;
using projetofinal_tryitter.Models;
using projetofinal_tryitter.Repository;

namespace projetofinal_tryitter.Controllers
{
    [Route("api")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ITryitterRepository _repository;

        public PostController(ITryitterRepository repository)
        {
            _repository = repository;
        }

        /// <summary> This function list a video</summary>
        /// <param name="id"> a video id</param>
        /// <returns> a video list</returns>
        [HttpGet("posts")]
        public IActionResult GetPosts()
        {
            return Ok(_repository.GetPosts());
        }

        /// <summary> This function list a video</summary>
        /// <param name="id"> a video id</param>
        /// <returns> a video list</returns>
        [HttpPost("escrever")]
        public IActionResult PostUsuario(Post post)
        {
            if(post == null) return BadRequest();
            _repository.AddPost(post);
            return Ok();
        }

    }
}

