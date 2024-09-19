using ApplicationLayer.Models.DTOs.UserDTOs;
using DomainLayer.Entities.Concrete;

namespace ApplicationLayer.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserDetailDTO>> GetAllUsersDetailAsync();
        Task<AppUser> GetUserById(int userId);
        Task<UserDetailDTO> GetUserDetailAsync(int userId);
        Task<bool> RegisterAsync(CreateUserDTO user);
        Task<bool> UpdateUserAsync(int userId, UpdateUserDTO updateUserDTO);
        Task<AppUser> GetUserByIdAsync(int userId);
        Task<UserLoginDTO> UserLogin(string email, string password);
    }
}