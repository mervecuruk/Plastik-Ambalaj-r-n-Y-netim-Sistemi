using ApplicationLayer.Models.DTOs.UserDTOs;
using ApplicationLayer.Services.UserService;
using DomainLayer.Entities.Concrete;
using InfrastructureLayer.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;

        public UserController(IUserService userService, SignInManager<AppUser> signInManager, AppDbContext context)
        {
            _userService = userService;
            _signInManager = signInManager;
            _context = context;
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
                return Ok(user);
            else
                return BadRequest();
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
        public async Task<IActionResult> GetUserDetail(int userId)
        {
            var user=await _userService.GetUserDetailAsync(userId);
            if (user is null) return NotFound("Kullanıcı bulunamadı");
            return Ok(user);
        }


        /// <summary>
        /// Admin Güncelleme
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="updateUserDTO"></param>
        /// <returns></returns>
        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUser(int userId, [FromBody] UpdateUserDTO updateUserDTO)
        {
            var user = await _userService.UpdateUserAsync(userId,updateUserDTO);
            if(user) return Ok(user);
            else return BadRequest();
        }



        /// <summary>
        /// Parametredeki Id'ye göre AppUser Döner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user is null) return NotFound("Kullanıcı bulunamadı");
            return Ok(user);
        }


        /// <summary>
        /// Parametredeki Email ve Password ile Login işlemi yapar
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpGet("{email}/{password}")]
        public async Task<IActionResult> LoginUser(string email, string password)
        {
            var result = await _userService.UserLogin(email, password);
            if (result.Error == true) return BadRequest("Email veya Şifre Hatalı");
            else
            {
                await _signInManager.SignInAsync(result.AppUser, false);
                return Ok(result);
            }
        }

        /// <summary>
        /// Kullanıcı LOGOUT
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }


    }
}