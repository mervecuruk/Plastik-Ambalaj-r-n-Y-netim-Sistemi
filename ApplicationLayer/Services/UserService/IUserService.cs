using ApplicationLayer.Models.DTOs.UserDTOs;
using DomainLayer;
using DomainLayer.Entities.Concrete;
using System.Security.Claims;

namespace ApplicationLayer.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserDetailDTO>> GetAllUsersDetailAsync();
        Task<UserDetailDTO> GetUserDetailAsync(int userId);
        Task<bool> RegisterAsync(CreateUserDTO user);
        Task<bool> UpdateUserAsync(int userId, UpdateUserDTO updateUserDTO);
        Task<AppUser> GetUserByIdAsync(int userId);
        Task<UserLoginDTO> UserLogin(string email, string password);
        Task<List<AppUser>> GetUserByKeyword(string keyword);
        Task<int> GetUserIdAsync(ClaimsPrincipal claims);
    }
}