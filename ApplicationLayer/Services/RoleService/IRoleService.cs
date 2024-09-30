using ApplicationLayer.Models.DTOs.RoleDTOs;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.RoleService
{
    public interface IRoleService
    {
        Task<IEnumerable<AppRole>> GetAllRolesAsync();

        Task<AppRole> GetRoleByIdAsync(int roleId);

        Task<bool> CreateRoleAsync(string roleName);

        Task<bool> UpdateRoleAsync(int roleId, string newRoleName);

        Task<bool> DeleteRoleAsync(int roleId);
        Task<bool> ChangeUserRoleAsync(ChangeUserRoleVM vm);
    }
}
