﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.UserDTOs
{
    public class JwtLoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
