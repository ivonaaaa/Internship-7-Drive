using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DumpDrive.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LastChanged = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FolderId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ChangeType = table.Column<int>(type: "integer", nullable: false),
                    FileId = table.Column<Guid>(type: "uuid", nullable: false),
                    ChangedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    FileId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    { new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2"), "bruno@gmail.com", "pass9", "bruno" },
                    { new Guid("452b0e07-2970-4fd4-b6ad-c8e6334285b1"), "ana@gmail.com", "pass7", "ana" },
                    { new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6"), "jure@gmail.com", "password456", "jure" },
                    { new Guid("a26a6659-dc93-4648-8369-f6d22bf81bb5"), "ivona@gmail.com", "password123", "ivona" }
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "Name", "OwnerId", "Status" },
                values: new object[,]
                {
                    { new Guid("0556fbe4-0248-4194-906a-03931cf77874"), "Archives", new Guid("a26a6659-dc93-4648-8369-f6d22bf81bb5"), 0 },
                    { new Guid("20579cf7-683a-43cb-96c1-1d1cea99e2ff"), "Videos", new Guid("452b0e07-2970-4fd4-b6ad-c8e6334285b1"), 1 },
                    { new Guid("22bf8709-b379-4694-8d7e-1da607c38a46"), "Downloads", new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6"), 1 },
                    { new Guid("24d9ab73-e685-4f17-95d1-27ee7c49fd7f"), "Music", new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2"), 0 },
                    { new Guid("560285d6-0b19-4d6d-a3e6-a8922eb9fee8"), "Projects", new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2"), 0 },
                    { new Guid("5cef4e4f-e45e-4c18-9412-95e0a60485ba"), "Documents", new Guid("a26a6659-dc93-4648-8369-f6d22bf81bb5"), 0 },
                    { new Guid("d35949dd-0fa8-4d63-9bf9-841bd1ceea8d"), "Photos", new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "FolderId", "LastChanged", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("1de5794d-5abf-477c-9f64-bf61af74870a"), new Guid("0556fbe4-0248-4194-906a-03931cf77874"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(4071), "archive.zip", 1 },
                    { new Guid("224e18e7-51d8-4b17-8de8-c2a88eb021d2"), new Guid("0556fbe4-0248-4194-906a-03931cf77874"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(4084), "data.csv", 0 },
                    { new Guid("32f425b4-023d-4471-af12-7a1dee7a9d31"), new Guid("5cef4e4f-e45e-4c18-9412-95e0a60485ba"), new DateTime(2024, 12, 23, 21, 33, 1, 633, DateTimeKind.Local).AddTicks(2231), "resume.pdf", 0 },
                    { new Guid("35471e3e-6b90-49fa-a5c0-6e8aa40e8c12"), new Guid("560285d6-0b19-4d6d-a3e6-a8922eb9fee8"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(4066), "presentation.pptx", 1 },
                    { new Guid("6d043be4-b9f1-4f97-819e-b43945beab48"), new Guid("22bf8709-b379-4694-8d7e-1da607c38a46"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(4069), "report.pdf", 0 },
                    { new Guid("bb617bf0-1e31-4fc2-9f64-1bc756bcd52b"), new Guid("20579cf7-683a-43cb-96c1-1d1cea99e2ff"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(4055), "movie.mp4", 1 },
                    { new Guid("d6e827ed-8306-48e8-9609-75b7e6e74c32"), new Guid("24d9ab73-e685-4f17-95d1-27ee7c49fd7f"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(4051), "song.mp3", 0 },
                    { new Guid("e8502326-5498-46e2-812f-bc822fdc760f"), new Guid("d35949dd-0fa8-4d63-9bf9-841bd1ceea8d"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(4021), "holiday.jpg", 1 },
                    { new Guid("fee5ed5b-e298-4b90-86a6-c67d5c81b884"), new Guid("560285d6-0b19-4d6d-a3e6-a8922eb9fee8"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(4058), "project_plan.docx", 0 }
                });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "Id", "ChangeType", "ChangedByUserId", "FileId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("02ded773-1683-43ad-b6ac-4d549ef86db5"), 1, new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2"), new Guid("35471e3e-6b90-49fa-a5c0-6e8aa40e8c12"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9616) },
                    { new Guid("0b214159-644a-42e4-8bf6-8a2e207e0861"), 0, new Guid("452b0e07-2970-4fd4-b6ad-c8e6334285b1"), new Guid("bb617bf0-1e31-4fc2-9f64-1bc756bcd52b"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9605) },
                    { new Guid("0c71fdf0-f7ce-455a-b42e-b704bb373cd9"), 0, new Guid("a26a6659-dc93-4648-8369-f6d22bf81bb5"), new Guid("6d043be4-b9f1-4f97-819e-b43945beab48"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9622) },
                    { new Guid("13e17b7f-5caa-493e-9118-99c19a7c981e"), 1, new Guid("452b0e07-2970-4fd4-b6ad-c8e6334285b1"), new Guid("224e18e7-51d8-4b17-8de8-c2a88eb021d2"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9630) },
                    { new Guid("1514934d-d374-4abf-b657-f011e3a21350"), 0, new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6"), new Guid("e8502326-5498-46e2-812f-bc822fdc760f"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9589) },
                    { new Guid("21d69c72-89a3-43a6-9c44-9cf9283479bc"), 1, new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2"), new Guid("d6e827ed-8306-48e8-9609-75b7e6e74c32"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9600) },
                    { new Guid("356b92c0-23e1-474e-9885-f99ec45a4982"), 0, new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6"), new Guid("fee5ed5b-e298-4b90-86a6-c67d5c81b884"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9609) },
                    { new Guid("824d9428-d5f6-4fb7-8f39-d5361c1a5ea7"), 0, new Guid("a26a6659-dc93-4648-8369-f6d22bf81bb5"), new Guid("32f425b4-023d-4471-af12-7a1dee7a9d31"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9568) },
                    { new Guid("f97650ed-a89a-43a8-8e3a-2184ee390939"), 0, new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2"), new Guid("1de5794d-5abf-477c-9f64-bf61af74870a"), new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(9626) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "FileId", "UserId" },
                values: new object[,]
                {
                    { new Guid("02ed643a-1a01-48fe-ae0a-63a292388130"), "Lovely picture!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6661), new Guid("e8502326-5498-46e2-812f-bc822fdc760f"), new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6") },
                    { new Guid("2ffa6dd0-433e-42f9-ba85-b29b484227a2"), "This resume could be better.", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6698), new Guid("32f425b4-023d-4471-af12-7a1dee7a9d31"), new Guid("452b0e07-2970-4fd4-b6ad-c8e6334285b1") },
                    { new Guid("4632e19f-dec6-4902-818e-26a47e12fc73"), "Data needs cleanup.", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6741), new Guid("224e18e7-51d8-4b17-8de8-c2a88eb021d2"), new Guid("a26a6659-dc93-4648-8369-f6d22bf81bb5") },
                    { new Guid("65d2594b-9fbd-4404-a3ca-c027d7f58b02"), "Nice music!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6666), new Guid("d6e827ed-8306-48e8-9609-75b7e6e74c32"), new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2") },
                    { new Guid("771366b1-9c06-4b9a-a9e0-b9141f9d5359"), "Great presentation!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6725), new Guid("35471e3e-6b90-49fa-a5c0-6e8aa40e8c12"), new Guid("452b0e07-2970-4fd4-b6ad-c8e6334285b1") },
                    { new Guid("866b0120-9b3a-4f02-bfe5-4a0416c525b0"), "Beautiful image!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6704), new Guid("e8502326-5498-46e2-812f-bc822fdc760f"), new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2") },
                    { new Guid("9dcc1f61-a049-4a4c-941b-94c53e1758bb"), "Important archive data.", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6737), new Guid("1de5794d-5abf-477c-9f64-bf61af74870a"), new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6") },
                    { new Guid("a65a4dc6-14a8-48b3-9c6a-e722a47bb3b0"), "Amazing video!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6715), new Guid("bb617bf0-1e31-4fc2-9f64-1bc756bcd52b"), new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6") },
                    { new Guid("b31ee5bf-4dad-49da-a545-f5027723fbd9"), "Excellent project plan!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6719), new Guid("fee5ed5b-e298-4b90-86a6-c67d5c81b884"), new Guid("59cd52ed-a7a7-4f8c-9470-fc6acc1ed8c6") },
                    { new Guid("bd8fe442-1faf-4591-b907-e50e690229b7"), "Cool video!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6692), new Guid("bb617bf0-1e31-4fc2-9f64-1bc756bcd52b"), new Guid("452b0e07-2970-4fd4-b6ad-c8e6334285b1") },
                    { new Guid("d2e650d7-4700-4fbf-a918-94e864ec2a6c"), "Great resume!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6631), new Guid("32f425b4-023d-4471-af12-7a1dee7a9d31"), new Guid("a26a6659-dc93-4648-8369-f6d22bf81bb5") },
                    { new Guid("f2a93e8e-1c37-4ff3-b013-4906b46bbed6"), "I dont like this song!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6708), new Guid("d6e827ed-8306-48e8-9609-75b7e6e74c32"), new Guid("1026c846-44d1-4a91-9f70-fb6930d95ae2") },
                    { new Guid("f5e8222b-0b63-42dc-a5de-d6ca3f458cfc"), "Very detailed report!", new DateTime(2024, 12, 23, 21, 33, 1, 635, DateTimeKind.Local).AddTicks(6730), new Guid("6d043be4-b9f1-4f97-819e-b43945beab48"), new Guid("a26a6659-dc93-4648-8369-f6d22bf81bb5") }
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
