using ApplicationLayer.Models.DTOs;
using ApplicationLayer.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDTO user)
        {
            if (await _userService.RegisterAsync(user))
            {
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
