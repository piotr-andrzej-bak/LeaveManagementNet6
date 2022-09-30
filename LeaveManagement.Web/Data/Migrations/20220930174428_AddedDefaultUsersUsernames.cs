using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b23",
                column: "ConcurrencyStamp",
                value: "90fb8651-0913-421c-b138-7f9ad699db7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b24",
                column: "ConcurrencyStamp",
                value: "361fc4f6-1b7c-4467-8b88-27bafd440f0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b22",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de38932-f6fe-4f38-baed-8c034f7f22b0", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAECKxXa5KSA1H44NYeANukIPvFrz2z3d7d0WeNVdsglajm5KQbIS8a+2O4EGFO9zM7Q==", "f1ec3552-75e7-42d2-94ae-005b3bf45470" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf7853a3-20c5-4904-a48a-7664d1b13b28", 0, "d6dddced-b270-4c86-82ae-122b4607117c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", true, "user", "test", false, null, "USER@TEST.COM", "USER@TEST.COM", "AQAAAAEAACcQAAAAEKID/y/mojiogF1C8TxEb3i6oawX1yDbTzfh6Oz47OSDNB9i40SEQ1/gsiUkqVG2OA==", null, false, "b9d17eb1-33d0-41c7-9146-2a760d8c7272", null, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b23",
                column: "ConcurrencyStamp",
                value: "f3c47e79-289e-4da7-9c45-b5c9de7d5948");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b24",
                column: "ConcurrencyStamp",
                value: "f63e7676-bee3-43f3-b559-695fe69099b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b22",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "584bf56b-2cd0-4c2c-b9b1-102298e2e947", false, null, "AQAAAAEAACcQAAAAEEa8nEJXpm0SCV3+QF0Sna+HXWQj7G+xWwB+753AzoLXuWfmUgqyHBHE2r49GCfTrg==", "61f74ddc-a292-4a1a-9773-559a520662bd" });
        }
    }
}
