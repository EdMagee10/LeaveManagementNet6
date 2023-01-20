using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6a-32e1-666a-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "4402623a-207d-430a-a638-4ad11dd9b65b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6b-32e1-666b-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "b2c9e834-d129-4270-9e3e-4826bed9d97a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6c-32e1-445c-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a75b401a-12e0-4bbe-ae59-adb32c55d2c5", true, "TEST@ADMIN", "AQAAAAEAACcQAAAAECbefwGiVBGsM0KJdijV1SmGAMEMiT78WA/0rsMEPv7CScglAFGCqmU9bXDX125RUw==", "1da7bdf4-cb86-4cfb-9cf9-6f8ccee2fc51", "test@admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6d-32e1-445d-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a928781a-e350-4211-9da7-847b66ebec59", true, "USER@ADMIN", "AQAAAAEAACcQAAAAEIavO+gWhTL1qbMxJAAYhesAWI/GY1TQO1pYhKARxBwkXucnzsjzNY1J+cqzo0C5wQ==", "ee2233d9-4071-447d-b59a-d7a007c18cba", "user@admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6a-32e1-666a-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "4f882695-2765-4922-93d8-0cf47cdec657");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6b-32e1-666b-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "ddd5b7ef-9016-44c2-b73a-d9e9d01ecf2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6c-32e1-445c-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "32c93c2a-b8a7-42e6-b3af-21f5be77bbb1", false, null, "AQAAAAEAACcQAAAAEMoTPd2nkEofMNVreiDWQkUEcHJ9e/HYXoNR5RUBeW56pldRwi6+VhgMebWyvuYsGg==", "7e7a8adb-4887-4a57-b75b-9c0a7160e469", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6d-32e1-445d-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e232e02c-487d-45d6-9d60-7370dd22a8b5", false, null, "AQAAAAEAACcQAAAAEL05CJablSXqohhmT1SMBF/bOMateO9dRtGl5EtZBD/KDldUpYR1wkvB4G5PG0fe9w==", "c2e61483-0a9f-46bd-9807-740ea57d6590", null });
        }
    }
}
