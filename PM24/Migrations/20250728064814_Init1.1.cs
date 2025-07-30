using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PM24.Migrations
{
    /// <inheritdoc />
    public partial class Init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConstructionObjectUser_ConstructionObjects_ConstructionObjectsId",
                table: "ConstructionObjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ConstructionObjectUser_Users_UsersId",
                table: "ConstructionObjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportFiles_TaskReports_TaskReportId",
                table: "ReportFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskReports_Tasks_TaskId",
                table: "TaskReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskReports_Users_AuthorId",
                table: "TaskReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ConstructionObjects_ConstructionObjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tasks_TaskDId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_ConstructionObjectUser_ConstructionObjects_ConstructionObjectsId",
                table: "ConstructionObjectUser",
                column: "ConstructionObjectsId",
                principalTable: "ConstructionObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConstructionObjectUser_Users_UsersId",
                table: "ConstructionObjectUser",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportFiles_TaskReports_TaskReportId",
                table: "ReportFiles",
                column: "TaskReportId",
                principalTable: "TaskReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskReports_Tasks_TaskId",
                table: "TaskReports",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskReports_Users_AuthorId",
                table: "TaskReports",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ConstructionObjects_ConstructionObjectId",
                table: "Tasks",
                column: "ConstructionObjectId",
                principalTable: "ConstructionObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tasks_TaskDId",
                table: "Users",
                column: "TaskDId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConstructionObjectUser_ConstructionObjects_ConstructionObjectsId",
                table: "ConstructionObjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ConstructionObjectUser_Users_UsersId",
                table: "ConstructionObjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportFiles_TaskReports_TaskReportId",
                table: "ReportFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskReports_Tasks_TaskId",
                table: "TaskReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskReports_Users_AuthorId",
                table: "TaskReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ConstructionObjects_ConstructionObjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tasks_TaskDId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_ConstructionObjectUser_ConstructionObjects_ConstructionObjectsId",
                table: "ConstructionObjectUser",
                column: "ConstructionObjectsId",
                principalTable: "ConstructionObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConstructionObjectUser_Users_UsersId",
                table: "ConstructionObjectUser",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportFiles_TaskReports_TaskReportId",
                table: "ReportFiles",
                column: "TaskReportId",
                principalTable: "TaskReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskReports_Tasks_TaskId",
                table: "TaskReports",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskReports_Users_AuthorId",
                table: "TaskReports",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ConstructionObjects_ConstructionObjectId",
                table: "Tasks",
                column: "ConstructionObjectId",
                principalTable: "ConstructionObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tasks_TaskDId",
                table: "Users",
                column: "TaskDId",
                principalTable: "Tasks",
                principalColumn: "Id");
        }
    }
}
