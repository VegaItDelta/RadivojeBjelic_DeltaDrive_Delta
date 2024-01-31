using System;
using System.ComponentModel.DataAnnotations;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}

