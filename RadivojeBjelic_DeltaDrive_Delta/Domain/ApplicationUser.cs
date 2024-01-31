using System;
using Microsoft.AspNetCore.Identity;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }

        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public DateTime Birthday { get;  set; }
    }
}

