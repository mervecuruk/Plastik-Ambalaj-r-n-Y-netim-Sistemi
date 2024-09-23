using ApplicationLayer.Models.DTOs.UserDTOs;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
        private readonly RoleManager<AppRole> _roleManager;

        public UserService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        /// <summary>
        /// Kullanıcı kayıt için oluşturulan metot
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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



        /// <summary>
        /// Sistemde katıtlı olan tüm kullanıcıların rolleri ile diğer bilgilerini listeleyen metot
        /// </summary>
        /// <returns></returns>
        public async Task<List<UserDetailDTO>> GetAllUsersDetailAsync()
        {
            var users = _userManager.Users.ToList();
            var userDetailsList = new List<UserDetailDTO>();
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);   //burada her bir kullanıcının rolünü aldım
                userDetailsList.Add(new UserDetailDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Role = roles.FirstOrDefault() //burada o kullanıcıya ait ilk rolü alıyoruz.Eğer birden fazla role sahip olursa ikinci rolü alır

                });
            }

            return userDetailsList;
        }


        /// <summary>
        /// Tek bir kullanıcının detayını gösteren metot
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<UserDetailDTO> GetUserDetailAsync(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());

            if (user == null)
                return null;

            var userDetail = new UserDetailDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault()
            };
            return userDetail;
        }


        /// <summary>
        /// Admin güncelleme metodu
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="updateUserDTO"></param>
        /// <returns></returns>
        public async Task<bool> UpdateUserAsync(int userId, UpdateUserDTO updateUserDTO)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
                return false;

            user.UpdateDate = DateTime.Now;
            user.FirstName = updateUserDTO.FirstName;
            user.LastName = updateUserDTO.LastName;
            user.Email = updateUserDTO.Email;


            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();
            user.PasswordHash = hasher.HashPassword(user, updateUserDTO.Password);

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
                return true;
            return false;
        }

        /// <summary>
        /// UserId'ye ait AppUser döner
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<AppUser> GetUserByIdAsync(int userId)
        {
            if (userId >= 0)
            {
                var user = await _userManager.FindByIdAsync(userId.ToString());
                if (user == null) return null;
                else return user;
            }
            else
                return null;
        }

        public async Task<UserLoginDTO> UserLogin(string email, string password)
        {
            UserLoginDTO userLogin = new UserLoginDTO();
            var user = await _userManager.FindByEmailAsync(email);
            bool pass = await _userManager.CheckPasswordAsync(user, password);
            if (user == null || pass != true)
            {
                userLogin.Error = true;
                return userLogin;
            }
            var roles = await _userManager.GetRolesAsync(user);

            userLogin.UserRoles = roles;
            userLogin.AppUser = user;
            userLogin.Error = false;
            return userLogin;
        }

        public async Task<List<AppUser>> GetUserByKeyword(string keyword)
        {
            var users = await _userManager.Users.Where(x => x.Email.ToLower().Contains(keyword.ToLower())).ToListAsync();
            if (users.Count > 0)
            {
                return users;
            }
            return null;
        }
    }
}