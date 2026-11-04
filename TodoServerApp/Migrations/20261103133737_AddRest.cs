using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 11, 3, 16, 37, 36, 777, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 11, 3, 16, 37, 36, 779, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 11, 3, 16, 37, 36, 779, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 11, 3, 16, 37, 36, 779, DateTimeKind.Local).AddTicks(23));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 11, 2, 15, 27, 17, 483, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 11, 2, 15, 27, 17, 484, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 11, 2, 15, 27, 17, 484, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 11, 2, 15, 27, 17, 484, DateTimeKind.Local).AddTicks(3042));
        }
    }
}
