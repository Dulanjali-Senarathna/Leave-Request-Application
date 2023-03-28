using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leave_Request_Application.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "fc0e6493-5ae7-427f-8204-7b7c2424683a",
                    UserId= "fc0e7493-5se7-427f-8204-7b7w2424683a"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "fc0e4483-5ac7-427f-8274-7b7c1424683a",
                    UserId = "2ab4a659-d9e0-41e0-bc26-172c545d981a"
                }
                );
        }
    }
}