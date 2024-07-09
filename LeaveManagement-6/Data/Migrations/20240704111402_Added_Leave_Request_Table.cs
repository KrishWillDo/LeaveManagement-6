using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement_6.Data.Migrations
{
    public partial class Added_Leave_Request_Table : Migration
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
                    RequestingEmployeeId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

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
    }
}
