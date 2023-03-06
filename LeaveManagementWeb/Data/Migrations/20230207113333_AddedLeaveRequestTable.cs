using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
