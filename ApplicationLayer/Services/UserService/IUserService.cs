using ApplicationLayer.Models.DTOs;

namespace ApplicationLayer.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserDetailDTO>> GetAllUsersDetailAsync();
        Task<UserDetailDTO> GetUserDetailAsync(int userId);
        Task<bool> RegisterAsync(CreateUserDTO user);
        Task<bool> UpdateAdminAsync(int userId, UpdateUserDTO updateUserDTO);
    }
}