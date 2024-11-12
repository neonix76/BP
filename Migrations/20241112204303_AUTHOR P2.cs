using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Migrations
{
    /// <inheritdoc />
    public partial class AUTHORP2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Posts2",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 43, 2, 799, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Posts2",
                keyColumn: "ID",
                keyValue: 1,
                column: "AuthorId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Posts2_AuthorId",
                table: "Posts2",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts2_AspNetUsers_AuthorId",
                table: "Posts2",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts2_AspNetUsers_AuthorId",
                table: "Posts2");

            migrationBuilder.DropIndex(
                name: "IX_Posts2_AuthorId",
                table: "Posts2");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Posts2");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 12, 57, 998, DateTimeKind.Local).AddTicks(5132));
        }
    }
}
