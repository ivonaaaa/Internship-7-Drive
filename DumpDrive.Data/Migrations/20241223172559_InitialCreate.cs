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
                    ChangeType = table.Column<string>(type: "text", nullable: false),
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
                    { new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8"), "bruno@gmail.com", "pass9", "bruno" },
                    { new Guid("2aa16ae1-1ab0-4384-b7ba-6f2288a6d470"), "ana@gmail.com", "pass7", "ana" },
                    { new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8"), "ivona@gmail.com", "password123", "ivona" },
                    { new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9"), "jure@gmail.com", "password456", "jure" }
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "Name", "OwnerId", "Status" },
                values: new object[,]
                {
                    { new Guid("258d0c88-4360-4ec3-b904-f65406deebe3"), "Projects", new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8"), 0 },
                    { new Guid("32cfeb41-b462-41d0-885f-b63661d9f1c2"), "Videos", new Guid("2aa16ae1-1ab0-4384-b7ba-6f2288a6d470"), 1 },
                    { new Guid("32d1d217-cd8e-4b9c-b1a7-6145fedf7bb6"), "Documents", new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8"), 0 },
                    { new Guid("7c77b084-8744-493f-9232-64524dd62485"), "Music", new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8"), 0 },
                    { new Guid("8b634a62-0546-46ed-9b2b-44f9cb9d3d81"), "Downloads", new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9"), 1 },
                    { new Guid("d57e963a-699a-4903-806d-65af672bdf32"), "Photos", new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9"), 1 },
                    { new Guid("e15cad81-6f4d-429b-9c76-152cb06f2f6b"), "Archives", new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "FolderId", "LastChanged", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("12f85cfa-303b-47e2-b95a-92551dc1d418"), new Guid("8b634a62-0546-46ed-9b2b-44f9cb9d3d81"), new DateTime(2024, 12, 23, 18, 25, 58, 268, DateTimeKind.Local).AddTicks(8031), "report.pdf", 0 },
                    { new Guid("1ac79a5c-31db-406c-bfd8-f3f29428380d"), new Guid("7c77b084-8744-493f-9232-64524dd62485"), new DateTime(2024, 12, 23, 18, 25, 58, 268, DateTimeKind.Local).AddTicks(7998), "song.mp3", 0 },
                    { new Guid("27732c22-87e0-43d2-8e55-5c65377b1b4e"), new Guid("e15cad81-6f4d-429b-9c76-152cb06f2f6b"), new DateTime(2024, 12, 23, 18, 25, 58, 268, DateTimeKind.Local).AddTicks(8034), "archive.zip", 1 },
                    { new Guid("31fa2f23-f357-4295-9e64-c52189bae71b"), new Guid("e15cad81-6f4d-429b-9c76-152cb06f2f6b"), new DateTime(2024, 12, 23, 18, 25, 58, 268, DateTimeKind.Local).AddTicks(8038), "data.csv", 0 },
                    { new Guid("733038f1-9fea-4c49-a2ac-6b4e4f88ca97"), new Guid("32cfeb41-b462-41d0-885f-b63661d9f1c2"), new DateTime(2024, 12, 23, 18, 25, 58, 268, DateTimeKind.Local).AddTicks(8003), "movie.mp4", 1 },
                    { new Guid("997a34b4-e72d-4597-9c29-5e46652da1bb"), new Guid("d57e963a-699a-4903-806d-65af672bdf32"), new DateTime(2024, 12, 23, 18, 25, 58, 268, DateTimeKind.Local).AddTicks(7963), "holiday.jpg", 1 },
                    { new Guid("ad6da18c-9bc1-4b7c-af3a-93f74381b542"), new Guid("32d1d217-cd8e-4b9c-b1a7-6145fedf7bb6"), new DateTime(2024, 12, 23, 18, 25, 58, 246, DateTimeKind.Local).AddTicks(9563), "resume.pdf", 0 },
                    { new Guid("c1f9dee4-fe2e-4162-a13b-f38c6dd25b64"), new Guid("258d0c88-4360-4ec3-b904-f65406deebe3"), new DateTime(2024, 12, 23, 18, 25, 58, 268, DateTimeKind.Local).AddTicks(8017), "presentation.pptx", 1 },
                    { new Guid("f3b22290-da73-4468-a6ce-c0a33bb18dc3"), new Guid("258d0c88-4360-4ec3-b904-f65406deebe3"), new DateTime(2024, 12, 23, 18, 25, 58, 268, DateTimeKind.Local).AddTicks(8007), "project_plan.docx", 0 }
                });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "Id", "ChangeType", "ChangedByUserId", "FileId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("27bf58f5-3959-40cd-92ee-5520b5027f60"), "Created", new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9"), new Guid("f3b22290-da73-4468-a6ce-c0a33bb18dc3"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3226) },
                    { new Guid("3b2407fb-15f2-4136-a586-e6d0e2b87541"), "Created", new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9"), new Guid("997a34b4-e72d-4597-9c29-5e46652da1bb"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3212) },
                    { new Guid("53646f7d-77a1-4943-a173-fe9f09470da5"), "Updated", new Guid("2aa16ae1-1ab0-4384-b7ba-6f2288a6d470"), new Guid("31fa2f23-f357-4295-9e64-c52189bae71b"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3252) },
                    { new Guid("66d6a1d5-adc5-422d-9e36-43315f838004"), "Created", new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8"), new Guid("ad6da18c-9bc1-4b7c-af3a-93f74381b542"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3179) },
                    { new Guid("71760b64-1adb-4176-aa29-3a62b37ad194"), "Created", new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8"), new Guid("12f85cfa-303b-47e2-b95a-92551dc1d418"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3242) },
                    { new Guid("7a7d8328-9afa-47fe-96ec-cdc18c1dd7c9"), "Created", new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8"), new Guid("27732c22-87e0-43d2-8e55-5c65377b1b4e"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3247) },
                    { new Guid("99f1f748-666c-4599-9303-6971e88055a9"), "Updated", new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8"), new Guid("1ac79a5c-31db-406c-bfd8-f3f29428380d"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3218) },
                    { new Guid("c951cab8-7208-439b-809b-3e774e128580"), "Updated", new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8"), new Guid("c1f9dee4-fe2e-4162-a13b-f38c6dd25b64"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3235) },
                    { new Guid("ee7befdf-8129-498c-b1ab-8381925a042e"), "Created", new Guid("2aa16ae1-1ab0-4384-b7ba-6f2288a6d470"), new Guid("733038f1-9fea-4c49-a2ac-6b4e4f88ca97"), new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(3222) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "FileId", "UserId" },
                values: new object[,]
                {
                    { new Guid("28549378-f147-4878-989a-b436914156b6"), "Very detailed report!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(934), new Guid("12f85cfa-303b-47e2-b95a-92551dc1d418"), new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8") },
                    { new Guid("3643e7f0-aea2-40d1-817b-bd844d8039e7"), "Amazing video!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(918), new Guid("733038f1-9fea-4c49-a2ac-6b4e4f88ca97"), new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9") },
                    { new Guid("368e3f5b-6bd7-4d2f-b87e-85cb1c9b11a2"), "Cool video!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(894), new Guid("733038f1-9fea-4c49-a2ac-6b4e4f88ca97"), new Guid("2aa16ae1-1ab0-4384-b7ba-6f2288a6d470") },
                    { new Guid("74fb98b4-8dc2-4c69-855d-c7e5cd6c120f"), "Data needs cleanup.", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(943), new Guid("31fa2f23-f357-4295-9e64-c52189bae71b"), new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8") },
                    { new Guid("86b43ac1-62bb-492a-828e-6fa9ae929a8f"), "Great resume!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(847), new Guid("ad6da18c-9bc1-4b7c-af3a-93f74381b542"), new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8") },
                    { new Guid("8a3e7b57-363b-4fd6-80a7-d8a406a2d183"), "This resume could be better.", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(899), new Guid("ad6da18c-9bc1-4b7c-af3a-93f74381b542"), new Guid("2aa16ae1-1ab0-4384-b7ba-6f2288a6d470") },
                    { new Guid("9b54ef00-8324-4378-a0c4-fc1b7fb8f319"), "Great presentation!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(927), new Guid("c1f9dee4-fe2e-4162-a13b-f38c6dd25b64"), new Guid("2aa16ae1-1ab0-4384-b7ba-6f2288a6d470") },
                    { new Guid("9dac0dab-6e9e-4bcd-95e2-e95afc95b949"), "Important archive data.", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(939), new Guid("27732c22-87e0-43d2-8e55-5c65377b1b4e"), new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9") },
                    { new Guid("a3479e9a-d674-4b82-9365-160937362813"), "Excellent project plan!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(922), new Guid("f3b22290-da73-4468-a6ce-c0a33bb18dc3"), new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9") },
                    { new Guid("b2c1be86-b12a-493c-a556-05de9dd556cc"), "I dont like this song!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(913), new Guid("1ac79a5c-31db-406c-bfd8-f3f29428380d"), new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8") },
                    { new Guid("c0eac115-7c24-4ef0-9537-f1e9a6141070"), "Lovely picture!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(875), new Guid("997a34b4-e72d-4597-9c29-5e46652da1bb"), new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9") },
                    { new Guid("c55ee1b4-898b-41d5-a465-1b51f525e395"), "Beautiful image!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(907), new Guid("997a34b4-e72d-4597-9c29-5e46652da1bb"), new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8") },
                    { new Guid("e2eefdff-e559-4ac4-9adb-ead043b74de8"), "Nice music!", new DateTime(2024, 12, 23, 18, 25, 58, 269, DateTimeKind.Local).AddTicks(890), new Guid("1ac79a5c-31db-406c-bfd8-f3f29428380d"), new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8") }
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
