using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leave_Request_Application.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0e4483-5ac7-427f-8274-7b7c1424683a",
                column: "ConcurrencyStamp",
                value: "0b665921-c5b3-425c-9e58-d68b0b61e45f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0e6493-5ae7-427f-8204-7b7c2424683a",
                column: "ConcurrencyStamp",
                value: "05409d22-838b-49d8-938c-864512026202");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ab4a659-d9e0-41e0-bc26-172c545d981a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5d69a93-cbcf-4a16-a4b2-9c56e7c6752f", "AQAAAAEAACcQAAAAEBgPPZnZEvMbaTreBWVsEY4y7FjELglmTrwt/8d3jHy+Sr+AtRVUn1UX3WkH3hnKtw==", "16c4aaa8-3261-4e47-a4af-4ed4ad86d06a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc0e7493-5se7-427f-8204-7b7w2424683a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4efb49e8-2340-4114-ac07-b4c5a70f7e6f", "AQAAAAEAACcQAAAAEF7iCJUs9nGhCOOkVU3RGUsn0wPN/LbwibhwDwfredh4vkBaTH1cstSs1RiW7dewQQ==", "ca19e546-08a5-42c8-9aa5-c0d40c14e343" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocation");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce39d443-eb4e-4c4c-94cd-77b5dc9d6a94", "AQAAAAEAACcQAAAAEK7egh8622N/jWbCpGasz8iQwVwoUqU1XF4UTaYZutuOZ7y70OuS1z59jUX/z6A8aw==", "8a8e2879-25b0-4de9-a4e6-7aabccf1087c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc0e7493-5se7-427f-8204-7b7w2424683a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da5bee05-e873-4090-985c-09d12d5d7982", "AQAAAAEAACcQAAAAEPJFpgl6Y9mvYqFYzYvqgdkV45SphDROKn+xd9U5boG1lTNHsMqccSqvIWIp9jknXQ==", "f67c271f-0107-4189-b12a-022d422147c4" });
        }
    }
}
