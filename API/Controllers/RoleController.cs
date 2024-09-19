﻿using ApplicationLayer.Models.DTOs.RoleDTOs;
using ApplicationLayer.Services.RoleService;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateRole([FromForm] CreateRoleDTO roleDTO)
        {
            if (ModelState.IsValid)
            {
                bool result = await _roleService.CreateRoleAsync(roleDTO.RoleName);
                if (result == false) return BadRequest("Bir hata meydana geldi");
                return Ok(result);
            }
            return BadRequest("Bir hata meydana geldi");
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllRoles()
        {
            var result = await _roleService.GetAllRolesAsync();
            if (result == null) return BadRequest("Hiçbir Role Bulunamadı");
            else return Ok(result);
        }


        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateRole(int id, UpdateRoleDTO updateDTO)
        {
            var result = await _roleService.GetRoleByIdAsync(id);
            
            if (result == null || string.IsNullOrEmpty(updateDTO.RoleName)) return BadRequest("Bir hata meydana geldi");
            else
            {
                if (await _roleService.UpdateRoleAsync(id, updateDTO.RoleName))
                    return Ok(result);
                else
                    return BadRequest("Bir hata meydana geldi");
            }
        }


        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteRole(int id)
        {
            bool result = await _roleService.DeleteRoleAsync(id);
            if (result == false) return BadRequest("Bir hata meydana geldi");
            return Ok();
        } 
    }
}