using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
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
                    { "91232a6a-32e1-666a-8494-6e6b5eb3f703", "4f882695-2765-4922-93d8-0cf47cdec657", "Administrator", "ADMINISTRATOR" },
                    { "91232a6b-32e1-666b-8494-6e6b5eb3f703", "ddd5b7ef-9016-44c2-b73a-d9e9d01ecf2e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "91232a6c-32e1-445c-8494-6e6b5eb3f703", 0, "32c93c2a-b8a7-42e6-b3af-21f5be77bbb1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@admin", false, "System", "Admin", false, null, "TEST@ADMIN", null, "AQAAAAEAACcQAAAAEMoTPd2nkEofMNVreiDWQkUEcHJ9e/HYXoNR5RUBeW56pldRwi6+VhgMebWyvuYsGg==", null, false, "7e7a8adb-4887-4a57-b75b-9c0a7160e469", null, false, null },
                    { "91232a6d-32e1-445d-8494-6e6b5eb3f703", 0, "e232e02c-487d-45d6-9d60-7370dd22a8b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@admin", false, "System", "User", false, null, "USER@ADMIN", null, "AQAAAAEAACcQAAAAEL05CJablSXqohhmT1SMBF/bOMateO9dRtGl5EtZBD/KDldUpYR1wkvB4G5PG0fe9w==", null, false, "c2e61483-0a9f-46bd-9807-740ea57d6590", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "91232a6a-32e1-666a-8494-6e6b5eb3f703", "91232a6c-32e1-445c-8494-6e6b5eb3f703" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "91232a6b-32e1-666b-8494-6e6b5eb3f703", "91232a6d-32e1-445d-8494-6e6b5eb3f703" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91232a6a-32e1-666a-8494-6e6b5eb3f703", "91232a6c-32e1-445c-8494-6e6b5eb3f703" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91232a6b-32e1-666b-8494-6e6b5eb3f703", "91232a6d-32e1-445d-8494-6e6b5eb3f703" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6a-32e1-666a-8494-6e6b5eb3f703");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6b-32e1-666b-8494-6e6b5eb3f703");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6c-32e1-445c-8494-6e6b5eb3f703");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6d-32e1-445d-8494-6e6b5eb3f703");
        }
    }
}
