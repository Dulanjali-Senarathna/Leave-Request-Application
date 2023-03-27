using Microsoft.AspNetCore.Identity;

namespace Leave_Request_Application.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RegisterId { get; set; }

        public string? NIC { get; set; }

    }
}
