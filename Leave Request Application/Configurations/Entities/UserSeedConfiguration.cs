using Leave_Request_Application.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leave_Request_Application.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "fc0e7493-5se7-427f-8204-7b7w2424683a",
                    Email= "admin@gmail.com",
                    UserName= "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    FirstName ="System",
                    LastName="Admin",
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    EmailConfirmed=true
                },
                 new Employee
                 {
                     Id = "2ab4a659-d9e0-41e0-bc26-172c545d981a",
                     Email = "dulanjalisenarathna@gmail.com",
                     NormalizedEmail = "DULANJALISENARATHNA@GMAIL.COM",
                     UserName = "dulanjalisenarathna@gmail.com",
                     NormalizedUserName = "DULANJALISENARATHNA@GMAIL.COM",
                     FirstName = "Dulanjali",
                     LastName = "Senarathna",
                     PasswordHash = hasher.HashPassword(null, "Dula@123"),
                     EmailConfirmed = true
                 });
        }
    }
}