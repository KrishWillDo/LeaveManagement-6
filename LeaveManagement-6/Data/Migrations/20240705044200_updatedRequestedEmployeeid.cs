using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement_6.Data.Migrations
{
    public partial class updatedRequestedEmployeeid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d478ab36-1256-443a-a170-474915a7f1b3",
                column: "ConcurrencyStamp",
                value: "b9d92c0e-8a09-4e15-9d03-a34554ffc643");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d578ab46-1234-443a-a170-474915a8g1b4",
                column: "ConcurrencyStamp",
                value: "4ac96b82-a93f-40a7-94af-2c8943eb371b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d478aa36-1256-444a-a169-474916c7f1b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e78b015-b652-4526-b9ad-0b616ba7e89a", "AQAAAAEAACcQAAAAEIDwEmxR/xvSPQyzpWVIad5EH3miypr9phoePgqdXxxa9ALjxLvF0wpVuAUZx8eXpw==", "8d57d947-d4a4-40d8-82ac-139744457d07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d578aa36-1287-444a-b269-474916c8f1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99fa3632-9fdd-4af9-82cb-67bebee41ca7", "AQAAAAEAACcQAAAAEFFp1BhsiX0XfYAfMoHq2E0tQTSK6ozERdV9r/8TZOLXsJMaNw4WRYG5gEnO3u44Mg==", "66b7c50b-3998-47f1-beb9-b77a0fd17c71" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
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
    }
}
