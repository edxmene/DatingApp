using Dating.Application.Contracts.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var Users = await _repository.GetPosts();
            return Ok(Users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var User = await _repository.GetPost(id);
            return Ok(User);
        }
    }
}
