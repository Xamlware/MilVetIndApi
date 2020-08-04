using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MilVetIndApi.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}