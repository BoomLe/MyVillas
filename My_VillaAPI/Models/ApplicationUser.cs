using Microsoft.AspNetCore.Identity;

namespace My_VillaAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { set; get; }
    }
}
