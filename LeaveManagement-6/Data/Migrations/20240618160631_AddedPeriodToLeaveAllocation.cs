using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement_6.Data.Migrations
{
    public partial class AddedPeriodToLeaveAllocation : Migration
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
                keyValue: "d478ab36-1256-443a-a170-474915a7f1b3",
                column: "ConcurrencyStamp",
                value: "bc7f341f-5248-4581-9647-6d671bacbb3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d578ab46-1234-443a-a170-474915a8g1b4",
                column: "ConcurrencyStamp",
                value: "601812f7-1ff3-49bc-818b-97f2911821b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d478aa36-1256-444a-a169-474916c7f1b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7083754-41ad-4e87-99af-4fd511f470bc", "AQAAAAEAACcQAAAAEGmWetCIxR+hfgMZOGAO3KFBoGwSGJOUPTkxfvouOTM7qwShQuQ1SVgbcJuguKzDTQ==", "2d5e880a-6439-4836-9c50-bfd355e03527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d578aa36-1287-444a-b269-474916c8f1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b24dc26b-66ec-4da2-b19a-ac0643bad0a4", "AQAAAAEAACcQAAAAEK8+gg/GKbn8y1UQ0QqDiozyvUp6dXJBXqKaGDEZvFLJ8ZgN7h+YxR1Ejax/HNDFlA==", "3038fe84-451f-41c0-a942-494f054582b1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "718e9792-93ba-40d8-a7a1-e1d886ae2f2a", "AQAAAAEAACcQAAAAEI/b5dfs2OBB7cG6vctgvwozlfZ4Qg9L1U+EbL7GYOrjbdq5Klyiwo7tHOlKEYi4Gg==", "441be4df-b0bb-40c4-903b-b09ec287a588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d578aa36-1287-444a-b269-474916c8f1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad7f38c3-7dc3-4018-ae2f-caf52b80fca2", "AQAAAAEAACcQAAAAELFmOFGkL9z+aBqdxFk7Sw+Xz41Qykfd3nlD+fc2ipeqn/BuZyquSAvemZNDDFLGVg==", "80494ac3-b406-42ca-935e-fefcac36b618" });
        }
    }
}
