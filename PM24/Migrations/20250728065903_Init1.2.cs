using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM24.Migrations
{
    /// <inheritdoc />
    public partial class Init12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tasks_TaskDId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tasks_TaskDId",
                table: "Users",
                column: "TaskDId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tasks_TaskDId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tasks_TaskDId",
                table: "Users",
                column: "TaskDId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
