using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6a-32e1-666a-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "e009b43e-0ccb-4303-91e1-601a1e29f6fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6b-32e1-666b-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "15e3142b-e0fb-4088-a9ba-3f5617574578");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6c-32e1-445c-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49078eb6-4856-45ca-9ab4-3938d589eb0a", "AQAAAAEAACcQAAAAEJwupKPJjBBLqLs/7hi677P6Eo/z8rZYVyNDUjX8V0rv15+S1q/lsBOBlaB3bpe4HA==", "799c9dc9-a31d-484d-bf81-90e37582d4b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6d-32e1-445d-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08ad03fc-bec7-4d61-979b-50c418038f2a", "AQAAAAEAACcQAAAAEKa75MJ0SgWc3CZzaeOw6bjWso6N+8jK4nByo9iVNgkUqTmQ73T6cMF9zEitS+fwWA==", "fed1d70c-7165-4dcf-838b-382e46314f2c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6a-32e1-666a-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "7a884914-a08d-41ec-b752-a62a63974f10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6b-32e1-666b-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "36553751-447e-4348-ba92-1f8c09858765");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6c-32e1-445c-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "226abdd4-ce9f-4c30-b272-e7d2db450843", "AQAAAAEAACcQAAAAEL6jev6SfZP1UHbcKyXleEpMsGzzoY0JDvStLPpAEVleBF5MVKICtHiwyntzHAbz+g==", "fe4bbf9f-6b70-430f-ac14-698db166c607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6d-32e1-445d-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2859af87-75da-41d6-901f-d4db16f2f5d2", "AQAAAAEAACcQAAAAELLu2FlhWku+uGRRvgPNj88Yy53LAKnRPFBcNGTntW9c50qYYKArLBT8pe2LN2e61Q==", "27e7fea8-0129-41c8-896d-2aa392b735ed" });
        }
    }
}
