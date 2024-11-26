using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Migrations
{
    /// <inheritdoc />
    public partial class addcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 26, 16, 41, 1, 170, DateTimeKind.Local).AddTicks(5982));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 0, 20, 32, 587, DateTimeKind.Local).AddTicks(621));
        }
    }
}
