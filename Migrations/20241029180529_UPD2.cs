using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Migrations
{
    /// <inheritdoc />
    public partial class UPD2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TEST",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TEST",
                table: "AspNetUsers");
        }
    }
}
