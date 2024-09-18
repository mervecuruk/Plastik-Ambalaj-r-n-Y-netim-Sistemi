using ApplicationLayer.Models.DTOs;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> RegisterAsync(CreateUserDTO user)
        {
            AppUser newUser = new AppUser();
            newUser.FirstName = user.FirstName;
            newUser.Email = user.Email;
            newUser.UserName = user.UserName;
            newUser.LastName = user.LastName;

            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();
            newUser.PasswordHash = hasher.HashPassword(newUser, user.Password);

            var result = await _userManager.CreateAsync(newUser);

            //Role ilişkisi
            await _userManager.AddToRoleAsync(newUser, "Visitor");

            return result.Succeeded;
        }
    }
}
