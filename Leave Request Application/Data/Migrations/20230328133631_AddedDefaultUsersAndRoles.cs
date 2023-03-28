using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leave_Request_Application.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fc0e4483-5ac7-427f-8274-7b7c1424683a", "03935be7-16e2-4eab-9f2e-17c73b83b3a0", "User", "USER" },
                    { "fc0e6493-5ae7-427f-8204-7b7c2424683a", "947b829e-5491-4475-bdd3-0f3149f28f1e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NIC", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisterId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2ab4a659-d9e0-41e0-bc26-172c545d981a", 0, "67f50237-1e37-482d-9d1f-41e4eb4a05f1", "dulanjalisenarathna@gmail.com", false, "Dulanjali", "Senarathna", false, null, null, "DULANJALISENARATHNA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGh5WHkN7IEcJU1Jk/Ir20Vltv+GoW5+IccOfKXFfc9xMuc16gJDToWpl+tUhZSuzQ==", null, false, null, "76218d68-7978-4b40-9861-0c0c5cd5edca", false, null },
                    { "fc0e7493-5se7-427f-8204-7b7w2424683a", 0, "0a3337cf-dcf0-4a07-bdfe-fab55438c7fc", "admin@gmail.com", false, "System", "Admin", false, null, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBlgO/LrF0ripb9+trJwdPTN3kJvXRx6OjeZoH/7NN44SQIPYOyCbKrwVC/Y6GAh3Q==", null, false, null, "93aac406-1e17-4a9d-b56e-677e5e7e4b3e", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fc0e4483-5ac7-427f-8274-7b7c1424683a", "2ab4a659-d9e0-41e0-bc26-172c545d981a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fc0e6493-5ae7-427f-8204-7b7c2424683a", "fc0e7493-5se7-427f-8204-7b7w2424683a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc0e4483-5ac7-427f-8274-7b7c1424683a", "2ab4a659-d9e0-41e0-bc26-172c545d981a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc0e6493-5ae7-427f-8204-7b7c2424683a", "fc0e7493-5se7-427f-8204-7b7w2424683a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0e4483-5ac7-427f-8274-7b7c1424683a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0e6493-5ae7-427f-8204-7b7c2424683a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ab4a659-d9e0-41e0-bc26-172c545d981a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc0e7493-5se7-427f-8204-7b7w2424683a");
        }
    }
}
