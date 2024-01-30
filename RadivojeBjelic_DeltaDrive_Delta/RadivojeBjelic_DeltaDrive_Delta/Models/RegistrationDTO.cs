using System;
using System.ComponentModel.DataAnnotations;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class RegistrationDTO
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Users first name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Users last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Users birthday name is required")]
        public  DateTime Birthday { get; set; }
    }
}

