using Microsoft.AspNetCore.Mvc;
using projetofinal_tryitter.Models;
using projetofinal_tryitter.Repository;

namespace projetofinal_tryitter.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ITryitterRepository _repository;

        public UserController(ITryitterRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("usuarios")]
        public IActionResult GetUsuarios()
        {
            return Ok(_repository.GetUsuarios());
        }

        [HttpPost("cadastrar")]
        public IActionResult PostUsuario(Usuario user)
        {
            if(user == null) return BadRequest();
            _repository.AddUsuario(user);
            return Ok();
        }

    }
}

