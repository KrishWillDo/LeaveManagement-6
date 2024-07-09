using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement_6.Data.Migrations
{
    public partial class UpdatedRequestCommentsasoptional : Migration
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
                keyValue: "d478ab36-1256-443a-a170-474915a7f1b3",
                column: "ConcurrencyStamp",
                value: "cddb3550-614a-4c34-b0c1-e2ec63f6c8ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d578ab46-1234-443a-a170-474915a8g1b4",
                column: "ConcurrencyStamp",
                value: "10f2072c-f72a-4a0d-8405-5821dd45a435");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d478aa36-1256-444a-a169-474916c7f1b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be5672f-fa50-4229-ae9a-7387b368007a", "AQAAAAEAACcQAAAAEAoKMixxBuPKPX0Bv2vOivVrRxSvzV2k//JGv1DH+IUW0NOqewUfa5BvlY9rvtRPUw==", "76133f6e-8f4d-4e28-baa6-6e9b287942ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d578aa36-1287-444a-b269-474916c8f1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1cdba94-2070-452e-958c-dd50108b460c", "AQAAAAEAACcQAAAAEAZMMvjUDVJSuSyZxcHQUDuvH2M+4tDIa+0T0iewNHmX8lZG5cIlcJSB8FsDzL+pag==", "ce16ff19-a865-410f-b21b-1135b12b3b07" });
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
                keyValue: "d478ab36-1256-443a-a170-474915a7f1b3",
                column: "ConcurrencyStamp",
                value: "41c580e9-35c1-411f-abf9-d934086a08f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d578ab46-1234-443a-a170-474915a8g1b4",
                column: "ConcurrencyStamp",
                value: "363a7770-f552-4ca4-ab25-7c5a60a05436");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d478aa36-1256-444a-a169-474916c7f1b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4995944a-63d4-47d1-b780-f0aa0bef3c48", "AQAAAAEAACcQAAAAENlB0PTqlQdJvcjKum9hc6rLGzZyUh7BjP7aGSdvRfUZIv/7VCfN36W6Uen2U5rBFQ==", "ff2af956-a2b0-4764-9c11-ae0dcce5c12e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d578aa36-1287-444a-b269-474916c8f1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5a92b50-e829-4a2b-8781-7db4069407a2", "AQAAAAEAACcQAAAAEIsoWMb5xVh6eIQODkAEfMjq3IebHxthk4LmLjKUaXLuReutADIgMn0vc4atqOyILA==", "264db69d-384a-4b2f-becc-6b2b53f72195" });
        }
    }
}
