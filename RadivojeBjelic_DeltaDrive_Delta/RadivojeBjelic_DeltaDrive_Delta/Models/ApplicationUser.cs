using System;
using Microsoft.AspNetCore.Identity;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime Birthday { get; internal set; }
    }
}

