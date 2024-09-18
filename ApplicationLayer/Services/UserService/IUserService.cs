using ApplicationLayer.Models.DTOs;

namespace ApplicationLayer.Services.UserService
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(CreateUserDTO user);
    }
}