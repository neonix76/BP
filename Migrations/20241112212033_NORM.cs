using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Migrations
{
    /// <inheritdoc />
    public partial class NORM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Posts2");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 0, 20, 32, 587, DateTimeKind.Local).AddTicks(621));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Posts2",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 0, 17, 45, 649, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Posts2",
                keyColumn: "ID",
                keyValue: 1,
                column: "Author",
                value: "123123");
        }
    }
}
