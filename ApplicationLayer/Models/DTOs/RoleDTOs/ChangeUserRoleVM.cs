﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.RoleDTOs
{
    public class ChangeUserRoleVM
    {
        public int UserId { get; set; }
        public int NewRole { get; set; }
    }
}
