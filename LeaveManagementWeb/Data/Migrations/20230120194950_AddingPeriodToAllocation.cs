using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6a-32e1-666a-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "3bbcc2cd-2048-496e-b4c1-4681264bb5a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91232a6b-32e1-666b-8494-6e6b5eb3f703",
                column: "ConcurrencyStamp",
                value: "1d212bd0-b675-491c-8608-38e38db28f73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6c-32e1-445c-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53ac6be8-cc2c-47a3-a2db-85a2d930e4f7", "AQAAAAEAACcQAAAAEAnQre64p5Ww6yYX3bj6XTVW+elr2uhZPdm0EVQC7zUM02YoZ9CMLv5iyvLlGNSWeA==", "18b8babc-b058-4f0c-8635-7d0bd9ee6a1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6d-32e1-445d-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59540962-73a5-4628-bf6b-04e18159a39d", "AQAAAAEAACcQAAAAEBKjglPnC19eCGnIi3JrGnnD1N1QknKkmzVB6Ltnedp4P7VZCsWdKNyzFpg7+z6Rug==", "4ef5ab7a-d452-415f-8d91-2e86d87987a0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a75b401a-12e0-4bbe-ae59-adb32c55d2c5", "AQAAAAEAACcQAAAAECbefwGiVBGsM0KJdijV1SmGAMEMiT78WA/0rsMEPv7CScglAFGCqmU9bXDX125RUw==", "1da7bdf4-cb86-4cfb-9cf9-6f8ccee2fc51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91232a6d-32e1-445d-8494-6e6b5eb3f703",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a928781a-e350-4211-9da7-847b66ebec59", "AQAAAAEAACcQAAAAEIavO+gWhTL1qbMxJAAYhesAWI/GY1TQO1pYhKARxBwkXucnzsjzNY1J+cqzo0C5wQ==", "ee2233d9-4071-447d-b59a-d7a007c18cba" });
        }
    }
}
