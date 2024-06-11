using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement_6.Data.Migrations
{
    public partial class addedroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d478ab36-1256-443a-a170-474915a7f1b3", "893c86a6-e0f3-4180-aeb2-7f6416fe433c", "Administrator", "ADMINISTRATOR" },
                    { "d578ab46-1234-443a-a170-474915a8g1b4", "6056140c-e282-4190-bc7b-0dc555f4eae8", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d478aa36-1256-444a-a169-474916c7f1b3", 0, "e00bd8a7-2d8b-40a4-9b86-5ac5e28ad8bc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "krishnovatiwe@gmail.com", false, "Krishna", "Kanth", false, null, "KRISHNOVATIWE@GMAIL.COM", "KRISHNOVATIWE@GMAIL.COM", "AQAAAAEAACcQAAAAEHvXfvt7vc1HtnJItogCmt3ZQbdc6GMRFtTSjCrPCORb4/+0jijTBNhl4ND39hluGA==", null, false, "55b23976-4cc9-4b12-b212-c687cee40235", "0", false, "Krishnovatiwe@gmail.com" },
                    { "d578aa36-1287-444a-b269-474916c8f1b2", 0, "4679d814-8916-4ee6-b1ff-259e5d5d0fe4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "Test", "User", false, null, "USER@TEST.COM", "USER@TEST.COM", "AQAAAAEAACcQAAAAEDMjsEbcySvD4i8U3TIkmWK6wFsPwyagUnbRy9z9BH/dnwOPxb+Tm4DTRUHRjRM3Rw==", null, false, "60bf1625-85af-4600-84b2-d339893dddd8", "0", false, "user@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d478ab36-1256-443a-a170-474915a7f1b3", "d478aa36-1256-444a-a169-474916c7f1b3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d578ab46-1234-443a-a170-474915a8g1b4", "d578aa36-1287-444a-b269-474916c8f1b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d478ab36-1256-443a-a170-474915a7f1b3", "d478aa36-1256-444a-a169-474916c7f1b3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d578ab46-1234-443a-a170-474915a8g1b4", "d578aa36-1287-444a-b269-474916c8f1b2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d478ab36-1256-443a-a170-474915a7f1b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d578ab46-1234-443a-a170-474915a8g1b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d478aa36-1256-444a-a169-474916c7f1b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d578aa36-1287-444a-b269-474916c8f1b2");
        }
    }
}
