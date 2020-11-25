using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
