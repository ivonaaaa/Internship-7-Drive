using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DumpDrive.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("0c88bb93-533d-4d60-90b0-de4bc3ecc834"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("281bcc96-36ea-4ff1-85d2-4a460b9039f3"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("559b093d-706f-4885-8c8d-713dae37e82e"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("618df100-5171-46ec-8041-fedda87083ef"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("8c5f70d1-6ab0-49a3-a7d1-8e179a96a35a"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("9256f822-3cdc-4d5d-a796-c8f0545d5947"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("aff5ccd9-ef3a-4de0-9c6f-a7ec4f62a1ef"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("b2c17a3e-e9a0-4cd9-89bc-7f05f53dc7f3"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("b8def73f-a43f-404c-882b-e85470b0b4c6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("00e61005-5264-4f64-ae23-a0100dacca9a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0614504b-1978-4248-a506-e62c2ab224fc"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("575b9fe9-8198-48a7-a4a6-d58ed7a09e21"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("5a11c4a1-c92e-4f51-becc-963a171a0be3"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7145adab-0e1a-4c64-b4ae-e0f836909dd8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ae829c37-aa06-450d-a8a7-7bf53d9e5938"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c9b4e8ef-0908-43e7-8386-ae102d7aa1c5"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ccecd784-80dd-4fb2-8ddb-8186f6ece6e7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("d032ba0b-3310-4c36-a546-42450ef15d59"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("d9cb7556-a96a-4fd4-9159-59414303a4bb"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ede3a530-6c71-478b-b2b6-b1ec406bff7f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("fb1fe139-546a-4540-a12c-ff5f13eaf207"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("fdcc3103-55fa-4286-87f5-7db925ca5ce4"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("18cac455-ad41-4319-a634-2a9d17689cca"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("2917e05a-7319-4f5b-a018-122b2e479d94"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("5ec7786d-67a2-45e8-9519-2c6a4c355d08"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("761d0321-9776-4220-b0c9-92af5776bade"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("abe87502-e27c-4b33-b738-0525f612dd89"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("ad9be4dc-22c6-453d-a653-1f226a5740db"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("af0f1246-c605-438a-8b86-74b4b10df437"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("04ab7409-d9c3-4a27-ad6c-3c072c684d43"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("ba5de896-154a-470f-ae0b-75e7025a31d1"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("c82b7434-7bb1-4970-899d-217227b4c8e6"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("e5dd2bd2-ade5-4807-9d77-470f82e81a80"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("e5e83150-d222-44d9-83c7-a358c7e88cdf"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("e7ff57c0-f9e0-487d-bc60-f86156f23c7e"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("fce49196-a5ce-4a2c-879c-7ac7d29503a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8448c96d-994e-499a-b088-4b000ad75f14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"), "jure@gmail.com", "password456", "jure" },
                    { new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"), "ana@gmail.com", "pass7", "ana" },
                    { new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"), "bruno@gmail.com", "pass9", "bruno" },
                    { new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"), "ivona@gmail.com", "password123", "ivona" }
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "Name", "OwnerId", "Status" },
                values: new object[,]
                {
                    { new Guid("35e17ffe-f17f-4daf-9959-28fd59225c6c"), "Projects", new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"), 0 },
                    { new Guid("876ac257-805f-42fe-bf9d-6bdc61513790"), "Downloads", new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"), 1 },
                    { new Guid("96a50c96-d8a5-489e-ba48-d8752937a29a"), "Music", new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"), 0 },
                    { new Guid("9f57fee3-0281-4964-9957-6e1e3f6fd585"), "Videos", new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"), 1 },
                    { new Guid("cbdef7a9-1287-4c83-bdf7-ceb5fa1858e6"), "Documents", new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"), 0 },
                    { new Guid("d05857a5-0949-4d5b-aa4e-812d95796107"), "Photos", new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"), 1 },
                    { new Guid("fb493f64-8f9e-423f-8609-5398ffea0e24"), "Archives", new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "FolderId", "LastChanged", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"), new Guid("9f57fee3-0281-4964-9957-6e1e3f6fd585"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1010), "movie.mp4", 1 },
                    { new Guid("23735773-88be-4f1a-bcb9-fefd2746aff5"), new Guid("fb493f64-8f9e-423f-8609-5398ffea0e24"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1031), "data.csv", 0 },
                    { new Guid("52631aa8-0ddd-46da-b460-e228813095bc"), new Guid("35e17ffe-f17f-4daf-9959-28fd59225c6c"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1012), "project_plan.docx", 0 },
                    { new Guid("5d59be09-3a25-4ada-8356-08e190ef1370"), new Guid("876ac257-805f-42fe-bf9d-6bdc61513790"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1025), "report.pdf", 0 },
                    { new Guid("615e4d6b-f6f5-4074-a1e3-3417039ef5ae"), new Guid("fb493f64-8f9e-423f-8609-5398ffea0e24"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1028), "archive.zip", 1 },
                    { new Guid("76db8152-f3ea-4ed1-837d-71eeeb88b3c7"), new Guid("35e17ffe-f17f-4daf-9959-28fd59225c6c"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1022), "presentation.pptx", 1 },
                    { new Guid("835acc43-8f26-4bd5-8605-c9da64022464"), new Guid("d05857a5-0949-4d5b-aa4e-812d95796107"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(977), "holiday.jpg", 1 },
                    { new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"), new Guid("cbdef7a9-1287-4c83-bdf7-ceb5fa1858e6"), new DateTime(2024, 12, 23, 18, 34, 32, 441, DateTimeKind.Local).AddTicks(5186), "resume.pdf", 0 },
                    { new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"), new Guid("96a50c96-d8a5-489e-ba48-d8752937a29a"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(1005), "song.mp3", 0 }
                });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "Id", "ChangeType", "ChangedByUserId", "FileId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("11c5b120-ef31-4994-80f7-7ad6a569e5e0"), "Created", new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"), new Guid("52631aa8-0ddd-46da-b460-e228813095bc"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5654) },
                    { new Guid("13f82380-aa4c-4736-b698-daa5b2f9193b"), "Updated", new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"), new Guid("76db8152-f3ea-4ed1-837d-71eeeb88b3c7"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5677) },
                    { new Guid("2be5eb5b-5b31-4405-a278-8c0bc3057f57"), "Created", new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"), new Guid("615e4d6b-f6f5-4074-a1e3-3417039ef5ae"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5687) },
                    { new Guid("43ffc831-34b2-4496-8308-f498d931a96c"), "Created", new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"), new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5650) },
                    { new Guid("574219fe-499a-459f-9106-59df36fbaccd"), "Created", new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"), new Guid("835acc43-8f26-4bd5-8605-c9da64022464"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5635) },
                    { new Guid("9e8e2376-89ee-4276-8ecb-aed6e0dece26"), "Updated", new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"), new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5640) },
                    { new Guid("ad6785af-ee8a-4c0d-8475-0593c4ff5115"), "Updated", new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"), new Guid("23735773-88be-4f1a-bcb9-fefd2746aff5"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5691) },
                    { new Guid("f378597b-ac59-4f9e-ac19-5b25d816e1d7"), "Created", new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"), new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5611) },
                    { new Guid("fc257c37-5399-4750-832d-3827748eed6e"), "Created", new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"), new Guid("5d59be09-3a25-4ada-8356-08e190ef1370"), new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(5681) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "FileId", "UserId" },
                values: new object[,]
                {
                    { new Guid("204af48d-348d-4849-8793-a24971b0cded"), "This resume could be better.", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3533), new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"), new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28") },
                    { new Guid("2446ceb9-81d1-464d-91b6-022feeb22606"), "Nice music!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3520), new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"), new Guid("c5465eac-27d8-405e-8e8a-eaced647b477") },
                    { new Guid("343e9b97-ca4f-4bc6-b8b0-ca607d51449f"), "Important archive data.", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3568), new Guid("615e4d6b-f6f5-4074-a1e3-3417039ef5ae"), new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc") },
                    { new Guid("52832096-ce06-49d6-904a-4acb73e010d8"), "Great resume!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3491), new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"), new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2") },
                    { new Guid("7158c0a1-27ea-4682-8b9e-91933101aca1"), "Very detailed report!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3564), new Guid("5d59be09-3a25-4ada-8356-08e190ef1370"), new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2") },
                    { new Guid("77a50885-fe18-4e46-b93c-d028b542a377"), "Great presentation!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3560), new Guid("76db8152-f3ea-4ed1-837d-71eeeb88b3c7"), new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28") },
                    { new Guid("8bbf5526-f7e2-4fa7-b770-ce5c748e00a6"), "Lovely picture!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3515), new Guid("835acc43-8f26-4bd5-8605-c9da64022464"), new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc") },
                    { new Guid("aa55974c-af19-455a-b3b8-163706f5a907"), "Excellent project plan!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3554), new Guid("52631aa8-0ddd-46da-b460-e228813095bc"), new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc") },
                    { new Guid("b9bfb166-d6b1-4017-b304-30d4c272c506"), "I dont like this song!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3544), new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"), new Guid("c5465eac-27d8-405e-8e8a-eaced647b477") },
                    { new Guid("bac32300-4c43-4981-9ad7-cf48c62ff52a"), "Cool video!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3525), new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"), new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28") },
                    { new Guid("c52b6f4a-88ee-4974-81c1-d2d9958ba44f"), "Amazing video!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3548), new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"), new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc") },
                    { new Guid("e8ee2d2f-5d35-44ea-83c2-7963b04a79db"), "Beautiful image!", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3540), new Guid("835acc43-8f26-4bd5-8605-c9da64022464"), new Guid("c5465eac-27d8-405e-8e8a-eaced647b477") },
                    { new Guid("ff0191ec-51cd-4540-ab65-6e4beb2a8bb8"), "Data needs cleanup.", new DateTime(2024, 12, 23, 18, 34, 32, 444, DateTimeKind.Local).AddTicks(3574), new Guid("23735773-88be-4f1a-bcb9-fefd2746aff5"), new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("11c5b120-ef31-4994-80f7-7ad6a569e5e0"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("13f82380-aa4c-4736-b698-daa5b2f9193b"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("2be5eb5b-5b31-4405-a278-8c0bc3057f57"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("43ffc831-34b2-4496-8308-f498d931a96c"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("574219fe-499a-459f-9106-59df36fbaccd"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("9e8e2376-89ee-4276-8ecb-aed6e0dece26"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("ad6785af-ee8a-4c0d-8475-0593c4ff5115"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("f378597b-ac59-4f9e-ac19-5b25d816e1d7"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("fc257c37-5399-4750-832d-3827748eed6e"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("204af48d-348d-4849-8793-a24971b0cded"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("2446ceb9-81d1-464d-91b6-022feeb22606"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("343e9b97-ca4f-4bc6-b8b0-ca607d51449f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("52832096-ce06-49d6-904a-4acb73e010d8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7158c0a1-27ea-4682-8b9e-91933101aca1"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("77a50885-fe18-4e46-b93c-d028b542a377"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("8bbf5526-f7e2-4fa7-b770-ce5c748e00a6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("aa55974c-af19-455a-b3b8-163706f5a907"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b9bfb166-d6b1-4017-b304-30d4c272c506"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("bac32300-4c43-4981-9ad7-cf48c62ff52a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c52b6f4a-88ee-4974-81c1-d2d9958ba44f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e8ee2d2f-5d35-44ea-83c2-7963b04a79db"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ff0191ec-51cd-4540-ab65-6e4beb2a8bb8"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("0e9c0b20-41a1-4a8c-ad82-e6fb432d3e96"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("23735773-88be-4f1a-bcb9-fefd2746aff5"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("52631aa8-0ddd-46da-b460-e228813095bc"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("5d59be09-3a25-4ada-8356-08e190ef1370"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("615e4d6b-f6f5-4074-a1e3-3417039ef5ae"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("76db8152-f3ea-4ed1-837d-71eeeb88b3c7"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("835acc43-8f26-4bd5-8605-c9da64022464"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("a9576931-4a7d-4e1a-bfe5-04f37183a465"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("f3380411-ae38-447f-9d0a-35374171e7bb"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("35e17ffe-f17f-4daf-9959-28fd59225c6c"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("876ac257-805f-42fe-bf9d-6bdc61513790"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("96a50c96-d8a5-489e-ba48-d8752937a29a"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("9f57fee3-0281-4964-9957-6e1e3f6fd585"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("cbdef7a9-1287-4c83-bdf7-ceb5fa1858e6"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("d05857a5-0949-4d5b-aa4e-812d95796107"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("fb493f64-8f9e-423f-8609-5398ffea0e24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cc482bc-2e1e-404e-b718-46161bd84fdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35d921a2-a2f4-48ff-8c42-e97bb6029b28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5465eac-27d8-405e-8e8a-eaced647b477"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7cd27c9-3228-4a36-9b9e-f6d49d7004f2"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"), "ivona@gmail.com", "password123", "ivona" },
                    { new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"), "jure@gmail.com", "password456", "jure" },
                    { new Guid("8448c96d-994e-499a-b088-4b000ad75f14"), "ana@gmail.com", "pass7", "ana" },
                    { new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"), "bruno@gmail.com", "pass9", "bruno" }
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "Name", "OwnerId", "Status" },
                values: new object[,]
                {
                    { new Guid("04ab7409-d9c3-4a27-ad6c-3c072c684d43"), "Photos", new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"), 1 },
                    { new Guid("ba5de896-154a-470f-ae0b-75e7025a31d1"), "Documents", new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"), 0 },
                    { new Guid("c82b7434-7bb1-4970-899d-217227b4c8e6"), "Downloads", new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"), 1 },
                    { new Guid("e5dd2bd2-ade5-4807-9d77-470f82e81a80"), "Archives", new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"), 0 },
                    { new Guid("e5e83150-d222-44d9-83c7-a358c7e88cdf"), "Projects", new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"), 0 },
                    { new Guid("e7ff57c0-f9e0-487d-bc60-f86156f23c7e"), "Videos", new Guid("8448c96d-994e-499a-b088-4b000ad75f14"), 1 },
                    { new Guid("fce49196-a5ce-4a2c-879c-7ac7d29503a6"), "Music", new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "FolderId", "LastChanged", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("18cac455-ad41-4319-a634-2a9d17689cca"), new Guid("ba5de896-154a-470f-ae0b-75e7025a31d1"), new DateTime(2024, 12, 23, 18, 30, 12, 545, DateTimeKind.Local).AddTicks(3460), "resume.pdf", 0 },
                    { new Guid("2917e05a-7319-4f5b-a018-122b2e479d94"), new Guid("e5e83150-d222-44d9-83c7-a358c7e88cdf"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4517), "project_plan.docx", 0 },
                    { new Guid("5ec7786d-67a2-45e8-9519-2c6a4c355d08"), new Guid("e5e83150-d222-44d9-83c7-a358c7e88cdf"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4533), "presentation.pptx", 1 },
                    { new Guid("761d0321-9776-4220-b0c9-92af5776bade"), new Guid("e5dd2bd2-ade5-4807-9d77-470f82e81a80"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4542), "data.csv", 0 },
                    { new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"), new Guid("fce49196-a5ce-4a2c-879c-7ac7d29503a6"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4509), "song.mp3", 0 },
                    { new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"), new Guid("e7ff57c0-f9e0-487d-bc60-f86156f23c7e"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4513), "movie.mp4", 1 },
                    { new Guid("abe87502-e27c-4b33-b738-0525f612dd89"), new Guid("04ab7409-d9c3-4a27-ad6c-3c072c684d43"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4481), "holiday.jpg", 1 },
                    { new Guid("ad9be4dc-22c6-453d-a653-1f226a5740db"), new Guid("c82b7434-7bb1-4970-899d-217227b4c8e6"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4537), "report.pdf", 0 },
                    { new Guid("af0f1246-c605-438a-8b86-74b4b10df437"), new Guid("e5dd2bd2-ade5-4807-9d77-470f82e81a80"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(4539), "archive.zip", 1 }
                });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "Id", "ChangeType", "ChangedByUserId", "FileId", "Timestamp" },
                values: new object[,]
                {
                    { new Guid("0c88bb93-533d-4d60-90b0-de4bc3ecc834"), "Created", new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"), new Guid("2917e05a-7319-4f5b-a018-122b2e479d94"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9122) },
                    { new Guid("281bcc96-36ea-4ff1-85d2-4a460b9039f3"), "Created", new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"), new Guid("af0f1246-c605-438a-8b86-74b4b10df437"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9139) },
                    { new Guid("559b093d-706f-4885-8c8d-713dae37e82e"), "Created", new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"), new Guid("ad9be4dc-22c6-453d-a653-1f226a5740db"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9134) },
                    { new Guid("618df100-5171-46ec-8041-fedda87083ef"), "Updated", new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"), new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9114) },
                    { new Guid("8c5f70d1-6ab0-49a3-a7d1-8e179a96a35a"), "Created", new Guid("768c24d1-830d-417b-ad80-f796b8b431e5"), new Guid("abe87502-e27c-4b33-b738-0525f612dd89"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9109) },
                    { new Guid("9256f822-3cdc-4d5d-a796-c8f0545d5947"), "Created", new Guid("8448c96d-994e-499a-b088-4b000ad75f14"), new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9118) },
                    { new Guid("aff5ccd9-ef3a-4de0-9c6f-a7ec4f62a1ef"), "Updated", new Guid("8448c96d-994e-499a-b088-4b000ad75f14"), new Guid("761d0321-9776-4220-b0c9-92af5776bade"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9142) },
                    { new Guid("b2c17a3e-e9a0-4cd9-89bc-7f05f53dc7f3"), "Updated", new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e"), new Guid("5ec7786d-67a2-45e8-9519-2c6a4c355d08"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9130) },
                    { new Guid("b8def73f-a43f-404c-882b-e85470b0b4c6"), "Created", new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b"), new Guid("18cac455-ad41-4319-a634-2a9d17689cca"), new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(9084) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "FileId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00e61005-5264-4f64-ae23-a0100dacca9a"), "Important archive data.", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7076), new Guid("af0f1246-c605-438a-8b86-74b4b10df437"), new Guid("768c24d1-830d-417b-ad80-f796b8b431e5") },
                    { new Guid("0614504b-1978-4248-a506-e62c2ab224fc"), "This resume could be better.", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7039), new Guid("18cac455-ad41-4319-a634-2a9d17689cca"), new Guid("8448c96d-994e-499a-b088-4b000ad75f14") },
                    { new Guid("575b9fe9-8198-48a7-a4a6-d58ed7a09e21"), "Great presentation!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7065), new Guid("5ec7786d-67a2-45e8-9519-2c6a4c355d08"), new Guid("8448c96d-994e-499a-b088-4b000ad75f14") },
                    { new Guid("5a11c4a1-c92e-4f51-becc-963a171a0be3"), "Lovely picture!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7019), new Guid("abe87502-e27c-4b33-b738-0525f612dd89"), new Guid("768c24d1-830d-417b-ad80-f796b8b431e5") },
                    { new Guid("7145adab-0e1a-4c64-b4ae-e0f836909dd8"), "I dont like this song!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7052), new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"), new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e") },
                    { new Guid("ae829c37-aa06-450d-a8a7-7bf53d9e5938"), "Cool video!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7035), new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"), new Guid("8448c96d-994e-499a-b088-4b000ad75f14") },
                    { new Guid("c9b4e8ef-0908-43e7-8386-ae102d7aa1c5"), "Excellent project plan!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7060), new Guid("2917e05a-7319-4f5b-a018-122b2e479d94"), new Guid("768c24d1-830d-417b-ad80-f796b8b431e5") },
                    { new Guid("ccecd784-80dd-4fb2-8ddb-8186f6ece6e7"), "Beautiful image!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7044), new Guid("abe87502-e27c-4b33-b738-0525f612dd89"), new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e") },
                    { new Guid("d032ba0b-3310-4c36-a546-42450ef15d59"), "Amazing video!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7056), new Guid("8591a6e3-ae28-4252-ab1d-46269a1029e4"), new Guid("768c24d1-830d-417b-ad80-f796b8b431e5") },
                    { new Guid("d9cb7556-a96a-4fd4-9159-59414303a4bb"), "Great resume!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(6996), new Guid("18cac455-ad41-4319-a634-2a9d17689cca"), new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b") },
                    { new Guid("ede3a530-6c71-478b-b2b6-b1ec406bff7f"), "Very detailed report!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7072), new Guid("ad9be4dc-22c6-453d-a653-1f226a5740db"), new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b") },
                    { new Guid("fb1fe139-546a-4540-a12c-ff5f13eaf207"), "Nice music!", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7030), new Guid("7f4f3756-0cc1-4512-972e-52a278b6c448"), new Guid("a19da8ac-735b-4892-ae7b-ee222b839d2e") },
                    { new Guid("fdcc3103-55fa-4286-87f5-7db925ca5ce4"), "Data needs cleanup.", new DateTime(2024, 12, 23, 18, 30, 12, 547, DateTimeKind.Local).AddTicks(7079), new Guid("761d0321-9776-4220-b0c9-92af5776bade"), new Guid("3ab60627-3775-4028-b7c9-927cb3218b3b") }
                });
        }
    }
}
