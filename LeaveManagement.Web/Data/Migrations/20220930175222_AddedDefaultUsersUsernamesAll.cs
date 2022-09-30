using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernamesAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b23",
                column: "ConcurrencyStamp",
                value: "0a1b493d-7e73-4e1d-bd1e-6914bcdb56d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b24",
                column: "ConcurrencyStamp",
                value: "650bd991-b87c-40ca-981b-aff48808606c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d6c715b8-2cc2-4c43-93ca-d9fe2642f4c5", "AQAAAAEAACcQAAAAEJbCwE4ikrxp5Fi3dTwSWUEzs1N1bYLFjlAALdiJc5Xtj7uy+5gq+ap3f82nIdSl/w==", "c9e5b67b-5812-4cc1-ac4c-8d05287eee30", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "378509b3-8899-4575-aff7-d8904c7bcfd9", "AQAAAAEAACcQAAAAEBJ95BYPlPg8ddhXBJoEiciRSd856sVeyIO0IqzR44ObP96Nehrlzued7pmJ6kRlNg==", "e82ee2d8-c600-4f8e-b602-52416a6ec5ea", "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1de38932-f6fe-4f38-baed-8c034f7f22b0", "AQAAAAEAACcQAAAAECKxXa5KSA1H44NYeANukIPvFrz2z3d7d0WeNVdsglajm5KQbIS8a+2O4EGFO9zM7Q==", "f1ec3552-75e7-42d2-94ae-005b3bf45470", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf7853a3-20c5-4904-a48a-7664d1b13b28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d6dddced-b270-4c86-82ae-122b4607117c", "AQAAAAEAACcQAAAAEKID/y/mojiogF1C8TxEb3i6oawX1yDbTzfh6Oz47OSDNB9i40SEQ1/gsiUkqVG2OA==", "b9d17eb1-33d0-41c7-9146-2a760d8c7272", null });
        }
    }
}
