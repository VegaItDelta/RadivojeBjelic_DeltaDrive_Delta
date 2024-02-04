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
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Users first name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Users last name is required")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "User's birthday is required")]
        public DateTime Birthday { get; set; }
    }
}

