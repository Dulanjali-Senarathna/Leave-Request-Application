using Leave_Request_Application.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;

namespace Leave_Request_Application.Configurations.Enities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "fc0e6493-5ae7-427f-8204-7b7c2424683a",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                 new IdentityRole
                 {
                     Id = "fc0e4483-5ac7-427f-8274-7b7c1424683a",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper(),
                 }
                ); ;

        }
    }
}