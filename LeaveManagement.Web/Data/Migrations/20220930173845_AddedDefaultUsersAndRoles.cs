using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf7853a3-20c5-4904-a48a-7664d1b13b23", "f3c47e79-289e-4da7-9c45-b5c9de7d5948", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf7853a3-20c5-4904-a48a-7664d1b13b24", "f63e7676-bee3-43f3-b559-695fe69099b0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf7853a3-20c5-4904-a48a-7664d1b13b22", 0, "584bf56b-2cd0-4c2c-b9b1-102298e2e947", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "admin", "test", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEEa8nEJXpm0SCV3+QF0Sna+HXWQj7G+xWwB+753AzoLXuWfmUgqyHBHE2r49GCfTrg==", null, false, "61f74ddc-a292-4a1a-9773-559a520662bd", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf7853a3-20c5-4904-a48a-7664d1b13b23", "bf7853a3-20c5-4904-a48a-7664d1b13b22" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b24");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf7853a3-20c5-4904-a48a-7664d1b13b23", "bf7853a3-20c5-4904-a48a-7664d1b13b22" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b22");
        }
    }
}
