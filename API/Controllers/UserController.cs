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


        /// <summary>
        /// Kullanıcı kayıt etme metodu
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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



        /// <summary>
        /// Tüm kullanıcıları detayları ile listeleyen metot
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<UserDetailDTO>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsersDetailAsync();
            if (users is null) return NotFound("Kullanıcı bulunamadı");
            return Ok(users);
        }


        /// <summary>
        /// Tek bir kullanıcının bilgilerini gösteren metot
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<ActionResult> GetUserDetail(int userId)
        {
            var user=await _userService.GetUserDetailAsync(userId);
            if (user is null) return NotFound("Kullanıcı bulunamadı");
            return Ok(user);
        }

        [HttpPut("{userId}")]
        public async Task<ActionResult> UpdateAdmin(int userId, [FromBody] UpdateUserDTO updateUserDTO)
        {
            var user = await _userService.UpdateAdminAsync(userId,updateUserDTO);
            if(user) return Ok(user);
            else return BadRequest();
        }








    }
}
