﻿using api_cinema_challenge.Enums;
using Microsoft.AspNetCore.Identity;

namespace api_cinema_challenge.Models
{
    public class ApplicationUser : IdentityUser
    {
        public UserRole Role { get; set; }
    }
}
