using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DumpDrive.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Folders_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LastChanged = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FolderId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_Folders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    FileId = table.Column<int>(type: "integer", nullable: false),
                    ChangedByUserId = table.Column<int>(type: "integer", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditLogs_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditLogs_Users_ChangedByUserId",
                        column: x => x.ChangedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    FileId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "ivona@gmail.com", "password123", "ivona" },
                    { 2, "jure@gmail.com", "password456", "jure" },
                    { 3, "bruno@gmail.com", "pass9", "bruno" },
                    { 4, "ana@gmail.com", "pass7", "ana" }
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "Name", "OwnerId", "Status" },
                values: new object[,]
                {
                    { 1, "Documents", 1, 0 },
                    { 2, "Photos", 2, 1 },
                    { 3, "Music", 3, 0 },
                    { 4, "Videos", 4, 1 },
                    { 5, "Projects", 3, 0 },
                    { 6, "Downloads", 2, 1 },
                    { 7, "Archives", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "FolderId", "LastChanged", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "resume.pdf", 0 },
                    { 2, 2, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "holiday.jpg", 1 },
                    { 3, 3, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "song.mp3", 0 },
                    { 4, 4, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "movie.mp4", 1 },
                    { 5, 5, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "project_plan.docx", 0 },
                    { 6, 5, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "presentation.pptx", 1 },
                    { 7, 6, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "report.pdf", 0 },
                    { 8, 7, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "archive.zip", 1 },
                    { 9, 7, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "data.csv", 0 }
                });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "Id", "ChangeType", "ChangedByUserId", "FileId", "Timestamp" },
                values: new object[,]
                {
                    { 1, 0, 1, 1, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, 0, 2, 2, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, 1, 3, 3, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, 0, 4, 4, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, 0, 2, 5, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, 1, 3, 6, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, 0, 1, 7, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, 0, 3, 8, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, 1, 4, 9, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "FileId", "UserId" },
                values: new object[,]
                {
                    { 1, "Great resume!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1 },
                    { 2, "Lovely picture!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 2, 2 },
                    { 3, "Nice music!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 3, 3 },
                    { 4, "Cool video!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 4, 4 },
                    { 5, "This resume could be better.", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 1, 4 },
                    { 6, "Beautiful image!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 2, 3 },
                    { 7, "I don't like this song!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 3, 3 },
                    { 8, "Amazing video!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 4, 2 },
                    { 9, "Excellent project plan!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 5, 2 },
                    { 10, "Great presentation!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 6, 4 },
                    { 11, "Very detailed report!", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 7, 1 },
                    { 12, "Important archive data.", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 8, 2 },
                    { 13, "Data needs cleanup.", new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 9, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_ChangedByUserId",
                table: "AuditLogs",
                column: "ChangedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_FileId",
                table: "AuditLogs",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FileId",
                table: "Comments",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FolderId",
                table: "Files",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_OwnerId",
                table: "Folders",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Folders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
