using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement_6.Data.Migrations
{
    public partial class addedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d478ab36-1256-443a-a170-474915a7f1b3",
                column: "ConcurrencyStamp",
                value: "a17028df-d860-4526-8729-7ade37cd3ae7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d578ab46-1234-443a-a170-474915a8g1b4",
                column: "ConcurrencyStamp",
                value: "c77ceecb-5187-4baa-9be9-cae3302ee581");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d478aa36-1256-444a-a169-474916c7f1b3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "718e9792-93ba-40d8-a7a1-e1d886ae2f2a", true, "AQAAAAEAACcQAAAAEI/b5dfs2OBB7cG6vctgvwozlfZ4Qg9L1U+EbL7GYOrjbdq5Klyiwo7tHOlKEYi4Gg==", "441be4df-b0bb-40c4-903b-b09ec287a588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d578aa36-1287-444a-b269-474916c8f1b2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad7f38c3-7dc3-4018-ae2f-caf52b80fca2", true, "AQAAAAEAACcQAAAAELFmOFGkL9z+aBqdxFk7Sw+Xz41Qykfd3nlD+fc2ipeqn/BuZyquSAvemZNDDFLGVg==", "80494ac3-b406-42ca-935e-fefcac36b618" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d478ab36-1256-443a-a170-474915a7f1b3",
                column: "ConcurrencyStamp",
                value: "893c86a6-e0f3-4180-aeb2-7f6416fe433c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d578ab46-1234-443a-a170-474915a8g1b4",
                column: "ConcurrencyStamp",
                value: "6056140c-e282-4190-bc7b-0dc555f4eae8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d478aa36-1256-444a-a169-474916c7f1b3",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e00bd8a7-2d8b-40a4-9b86-5ac5e28ad8bc", false, "AQAAAAEAACcQAAAAEHvXfvt7vc1HtnJItogCmt3ZQbdc6GMRFtTSjCrPCORb4/+0jijTBNhl4ND39hluGA==", "55b23976-4cc9-4b12-b212-c687cee40235" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d578aa36-1287-444a-b269-474916c8f1b2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4679d814-8916-4ee6-b1ff-259e5d5d0fe4", false, "AQAAAAEAACcQAAAAEDMjsEbcySvD4i8U3TIkmWK6wFsPwyagUnbRy9z9BH/dnwOPxb+Tm4DTRUHRjRM3Rw==", "60bf1625-85af-4600-84b2-d339893dddd8" });
        }
    }
}
