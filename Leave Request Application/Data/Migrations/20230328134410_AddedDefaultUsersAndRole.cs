using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leave_Request_Application.Data.Migrations
{
    public partial class AddedDefaultUsersAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0e4483-5ac7-427f-8274-7b7c1424683a",
                column: "ConcurrencyStamp",
                value: "1528a084-d41a-42c6-ba90-9b778ee31ac9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0e6493-5ae7-427f-8204-7b7c2424683a",
                column: "ConcurrencyStamp",
                value: "ca4bb400-eb79-4d9c-95dc-2207fbfe91ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ab4a659-d9e0-41e0-bc26-172c545d981a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ce39d443-eb4e-4c4c-94cd-77b5dc9d6a94", true, "DULANJALISENARATHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEK7egh8622N/jWbCpGasz8iQwVwoUqU1XF4UTaYZutuOZ7y70OuS1z59jUX/z6A8aw==", "8a8e2879-25b0-4de9-a4e6-7aabccf1087c", "dulanjalisenarathna@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc0e7493-5se7-427f-8204-7b7w2424683a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "da5bee05-e873-4090-985c-09d12d5d7982", true, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPJFpgl6Y9mvYqFYzYvqgdkV45SphDROKn+xd9U5boG1lTNHsMqccSqvIWIp9jknXQ==", "f67c271f-0107-4189-b12a-022d422147c4", "admin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0e4483-5ac7-427f-8274-7b7c1424683a",
                column: "ConcurrencyStamp",
                value: "03935be7-16e2-4eab-9f2e-17c73b83b3a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0e6493-5ae7-427f-8204-7b7c2424683a",
                column: "ConcurrencyStamp",
                value: "947b829e-5491-4475-bdd3-0f3149f28f1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ab4a659-d9e0-41e0-bc26-172c545d981a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "67f50237-1e37-482d-9d1f-41e4eb4a05f1", false, null, "AQAAAAEAACcQAAAAEGh5WHkN7IEcJU1Jk/Ir20Vltv+GoW5+IccOfKXFfc9xMuc16gJDToWpl+tUhZSuzQ==", "76218d68-7978-4b40-9861-0c0c5cd5edca", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc0e7493-5se7-427f-8204-7b7w2424683a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0a3337cf-dcf0-4a07-bdfe-fab55438c7fc", false, null, "AQAAAAEAACcQAAAAEBlgO/LrF0ripb9+trJwdPTN3kJvXRx6OjeZoH/7NN44SQIPYOyCbKrwVC/Y6GAh3Q==", "93aac406-1e17-4a9d-b56e-677e5e7e4b3e", null });
        }
    }
}
