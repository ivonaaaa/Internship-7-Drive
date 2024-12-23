using DumpDrive.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DumpDrive.Data.Seeds
{
    public static class DbSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(new List<User>
                {
                    new User("ivona@gmail.com", "password123", "ivona") { Id = 1 },
                    new User("jure@gmail.com", "password456", "jure") { Id = 2 },
                    new User("bruno@gmail.com", "pass9", "bruno") { Id = 3 },
                    new User("ana@gmail.com", "pass7", "ana") { Id = 4 }
                });

            builder.Entity<Folder>()
                .HasData(new List<Folder>
                {
                    new Folder("Documents", 1) { Id = 1, Status = SharedStatus.Private },
                    new Folder("Photos", 2) { Id = 2, Status = SharedStatus.Shared },
                    new Folder("Music", 3) { Id = 3, Status = SharedStatus.Private },
                    new Folder("Videos", 4) { Id = 4, Status = SharedStatus.Shared },
                    new Folder("Projects", 3) { Id = 5, Status = SharedStatus.Private },
                    new Folder("Downloads", 2) { Id = 6, Status = SharedStatus.Shared },
                    new Folder("Archives", 1) { Id = 7, Status = SharedStatus.Private }
                });

            builder.Entity<DumpFile>()
                .HasData(new List<DumpFile>
                {
                    new DumpFile("resume.pdf", 1) { Id = 1, Status = SharedStatus.Private, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("holiday.jpg", 2) { Id = 2, Status = SharedStatus.Shared, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("song.mp3", 3) { Id = 3, Status = SharedStatus.Private, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("movie.mp4", 4) { Id = 4, Status = SharedStatus.Shared, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("project_plan.docx", 5) { Id = 5, Status = SharedStatus.Private, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("presentation.pptx", 5) { Id = 6, Status = SharedStatus.Shared, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("report.pdf", 6) { Id = 7, Status = SharedStatus.Private, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("archive.zip", 7) { Id = 8, Status = SharedStatus.Shared, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("data.csv", 7) { Id = 9, Status = SharedStatus.Private, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) }
                });

            builder.Entity<Comment>()
                .HasData(new List<Comment>
                {
                    new Comment("Great resume!", 1, 1) { Id = 1, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Lovely picture!", 2, 2) { Id = 2, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Nice music!", 3, 3) { Id = 3, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Cool video!", 4, 4) { Id = 4, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("This resume could be better.", 1, 4) { Id = 5, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Beautiful image!", 2, 3) { Id = 6, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("I don't like this song!", 3, 3) { Id = 7, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Amazing video!", 4, 2) { Id = 8, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Excellent project plan!", 5, 2) { Id = 9, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Great presentation!", 6, 4) { Id = 10, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Very detailed report!", 7, 1) { Id = 11, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Important archive data.", 8, 2) { Id = 12, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Data needs cleanup.", 9, 1) { Id = 13, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) }
                });

            builder.Entity<AuditLog>()
                .HasData(new List<AuditLog>
                {
                    new AuditLog(ChangeType.Created, 1, 1) { Id = 1, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Created, 2, 2) { Id = 2, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Updated, 3, 3) { Id = 3, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Created, 4, 4) { Id = 4, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Created, 5, 2) { Id = 5, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Updated, 6, 3) { Id = 6, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Created, 7, 1) { Id = 7, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Created, 8, 3) { Id = 8, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Updated, 9, 4) { Id = 9, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) }
                });

        }
    }
}
