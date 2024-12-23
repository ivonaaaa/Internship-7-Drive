using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DumpDrive.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("27bf58f5-3959-40cd-92ee-5520b5027f60"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("3b2407fb-15f2-4136-a586-e6d0e2b87541"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("53646f7d-77a1-4943-a173-fe9f09470da5"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("66d6a1d5-adc5-422d-9e36-43315f838004"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("71760b64-1adb-4176-aa29-3a62b37ad194"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("7a7d8328-9afa-47fe-96ec-cdc18c1dd7c9"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("99f1f748-666c-4599-9303-6971e88055a9"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("c951cab8-7208-439b-809b-3e774e128580"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "Id",
                keyValue: new Guid("ee7befdf-8129-498c-b1ab-8381925a042e"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("28549378-f147-4878-989a-b436914156b6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("3643e7f0-aea2-40d1-817b-bd844d8039e7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("368e3f5b-6bd7-4d2f-b87e-85cb1c9b11a2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("74fb98b4-8dc2-4c69-855d-c7e5cd6c120f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("86b43ac1-62bb-492a-828e-6fa9ae929a8f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("8a3e7b57-363b-4fd6-80a7-d8a406a2d183"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9b54ef00-8324-4378-a0c4-fc1b7fb8f319"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9dac0dab-6e9e-4bcd-95e2-e95afc95b949"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a3479e9a-d674-4b82-9365-160937362813"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b2c1be86-b12a-493c-a556-05de9dd556cc"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c0eac115-7c24-4ef0-9537-f1e9a6141070"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c55ee1b4-898b-41d5-a465-1b51f525e395"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e2eefdff-e559-4ac4-9adb-ead043b74de8"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("12f85cfa-303b-47e2-b95a-92551dc1d418"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("1ac79a5c-31db-406c-bfd8-f3f29428380d"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("27732c22-87e0-43d2-8e55-5c65377b1b4e"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("31fa2f23-f357-4295-9e64-c52189bae71b"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("733038f1-9fea-4c49-a2ac-6b4e4f88ca97"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("997a34b4-e72d-4597-9c29-5e46652da1bb"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("ad6da18c-9bc1-4b7c-af3a-93f74381b542"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("c1f9dee4-fe2e-4162-a13b-f38c6dd25b64"));

            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("f3b22290-da73-4468-a6ce-c0a33bb18dc3"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("258d0c88-4360-4ec3-b904-f65406deebe3"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("32cfeb41-b462-41d0-885f-b63661d9f1c2"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("32d1d217-cd8e-4b9c-b1a7-6145fedf7bb6"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("7c77b084-8744-493f-9232-64524dd62485"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("8b634a62-0546-46ed-9b2b-44f9cb9d3d81"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("d57e963a-699a-4903-806d-65af672bdf32"));

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumn: "Id",
                keyValue: new Guid("e15cad81-6f4d-429b-9c76-152cb06f2f6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cd2f244-082a-418b-9bc2-112a173ef8b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2aa16ae1-1ab0-4384-b7ba-6f2288a6d470"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d71b4f5a-7afa-4271-8511-c914b0e7e2c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfe511b2-4bd4-4a00-af27-cbbb956d1ac9"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
