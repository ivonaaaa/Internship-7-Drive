using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DumpDrive.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSharedFiles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    FileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSharedFiles", x => new { x.UserId, x.FileId });
                    table.ForeignKey(
                        name: "FK_UserSharedFiles_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSharedFiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSharedFolders",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    FolderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSharedFolders", x => new { x.UserId, x.FolderId });
                    table.ForeignKey(
                        name: "FK_UserSharedFolders_Folders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSharedFolders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "Name", "OwnerId", "Status" },
                values: new object[] { 10, "Recipes", 4, 1 });

            migrationBuilder.InsertData(
                table: "UserSharedFiles",
                columns: new[] { "FileId", "UserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 5, 2 },
                    { 7, 2 },
                    { 4, 3 },
                    { 6, 3 },
                    { 1, 4 },
                    { 8, 4 }
                });

            migrationBuilder.InsertData(
                table: "UserSharedFolders",
                columns: new[] { "FolderId", "UserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 5, 2 },
                    { 6, 2 },
                    { 4, 3 },
                    { 1, 4 },
                    { 7, 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 5, "marko@gmail.com", "marko123", "marko" },
                    { 6, "petra@gmail.com", "petra456", "petra" }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "FolderId", "LastChanged", "Name", "Status" },
                values: new object[] { 12, 10, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "recipe.pdf", 1 });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "Name", "OwnerId", "Status" },
                values: new object[,]
                {
                    { 8, "Work", 5, 1 },
                    { 9, "Games", 6, 0 },
                    { 11, "Notes", 6, 0 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "FileId", "UserId" },
                values: new object[] { 16, "Nice recipe!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 12, 1 });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "FolderId", "LastChanged", "Name", "Status" },
                values: new object[,]
                {
                    { 10, 8, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "work_report.docx", 1 },
                    { 11, 9, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "game_review.txt", 0 },
                    { 13, 11, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "notes.txt", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserSharedFolders",
                columns: new[] { "FolderId", "UserId" },
                values: new object[] { 8, 3 });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "Id", "ChangeType", "ChangedByUserId", "FileId", "Timestamp" },
                values: new object[,]
                {
                    { 10, 0, 5, 10, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, 0, 6, 11, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "FileId", "UserId" },
                values: new object[,]
                {
                    { 14, "Work file looks great!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 10, 3 },
                    { 15, "Love the game review!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 11, 4 },
                    { 17, "Helpful notes!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 13, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSharedFiles_FileId",
                table: "UserSharedFiles",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSharedFolders_FolderId",
                table: "UserSharedFolders",
                column: "FolderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSharedFiles");

            migrationBuilder.DropTable(
                name: "UserSharedFolders");

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
