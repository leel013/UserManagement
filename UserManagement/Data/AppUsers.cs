using Microsoft.AspNetCore.Identity;

namespace UserManagement.Data
{
    public class AppUsers : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePic { get; set; }
        public string? Address { get; set; }
        public string? Resume { get; set; }




    }
}
