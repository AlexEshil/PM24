using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM24.Migrations
{
    /// <inheritdoc />
    public partial class Init20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AdminUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AdminUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
