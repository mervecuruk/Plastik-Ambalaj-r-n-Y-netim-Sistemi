using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.UserDTOs
{
    public class UserLoginDTO
    {
        public IEnumerable<string> UserRoles;
        public AppUser AppUser { get; set; }
        public bool Error { get; set; } = false;
    }
}
