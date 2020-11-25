using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class User : IdentityUser 
    {
        //Inherits all  IdentityUser properties
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
