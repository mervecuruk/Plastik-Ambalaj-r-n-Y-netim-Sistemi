using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.JwtService
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public List<string> UserRoles { get; set; } // Kullanıcı rollerini almak için
        public string UserId { get; set; }
    }
}
