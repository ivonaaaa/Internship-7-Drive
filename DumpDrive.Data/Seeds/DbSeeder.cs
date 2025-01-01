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
                    new User("ivona@gmail.com", "pass1", "ivona") { Id = 1 },
                    new User("jure@gmail.com", "pass2", "jure") { Id = 2 },
                    new User("bruno@gmail.com", "pass3", "bruno") { Id = 3 },
                    new User("ana@gmail.com", "pass4", "ana") { Id = 4 },
                    new User("leo@ffst.hr", "pass5", "leo") { Id = 5 },
                    new User("hana@pmfst.chr", "pass6", "hana") { Id = 6 }
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
                    new Folder("Archives", 1) { Id = 7, Status = SharedStatus.Private },
                    new Folder("Work", 5) { Id = 8, Status = SharedStatus.Shared },
                    new Folder("Games", 6) { Id = 9, Status = SharedStatus.Private },
                    new Folder("Recipes", 4) { Id = 10, Status = SharedStatus.Shared },
                    new Folder("Notes", 6) { Id = 11, Status = SharedStatus.Private }
                });

            builder.Entity<DumpFile>()
                .HasData(new List<DumpFile>
                {
                    new DumpFile("resume.pdf", 1) { Id = 1, Content = "My resume. Lorem ipsum.", Status = SharedStatus.Private, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("holiday.jpg", 2) { Id = 2, Content = "Image of a holiday memory!", Status = SharedStatus.Shared, LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new DumpFile("song.mp3", 3) { Id = 3, Content = "Never Gonna Give You Up", Status = SharedStatus.Private , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("movie.mp4", 4) { Id = 4, Content = "Movie: Interstellar", Status = SharedStatus.Shared , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("project_plan.docx", 5) { Id = 5, Content = "Plan for a project.", Status = SharedStatus.Private , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("presentation.pptx", 5) { Id = 6, Content = "A presentation about my project.", Status = SharedStatus.Shared , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("report.pdf", 6) { Id = 7, Content = "Report number 6.", Status = SharedStatus.Private , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("archive.zip", 7) { Id = 8, Content = "Here are saved some important documents.", Status = SharedStatus.Shared , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("data.csv", 7) { Id = 9, Content = "Seed data for my database.", Status = SharedStatus.Private , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("work_report.docx", 8) { Id = 10, Content = "Week 1: Number of working hours - 40\nWeek 2: Number of working hours - 38", Status = SharedStatus.Shared , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("game_review.txt", 9) { Id = 11, Content = "The game was fun to play but too many bad huys to fight", Status = SharedStatus.Private , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("recipe.pdf", 10) { Id = 12, Content = "Cookies: 2 eggs, flour, water, vanilla extract", Status = SharedStatus.Shared , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new DumpFile("notes.txt", 11) { Id = 13, Content = "Lorem ipsum.", Status = SharedStatus.Private , LastChanged = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)}
                });

            builder.Entity<Comment>()
                .HasData(new List<Comment>
                {
                    new Comment("Great resume!", 1, 1) { Id = 1, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Lovely picture!", 2, 2) { Id = 2, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Nice music!", 3, 3) { Id = 3, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new Comment("Cool video!", 4, 4) { Id = 4, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("This resume could be better.", 1, 4) { Id = 5, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Beautiful image!", 2, 3) { Id = 6, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("I don't like this song!", 3, 3) { Id = 7, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Amazing video!", 4, 2) { Id = 8, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Excellent project plan!", 5, 2) { Id = 9, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Great presentation!", 6, 4) { Id = 10, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Very detailed report!", 7, 1) { Id = 11, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Important archive data.", 8, 2) { Id = 12, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Data needs cleanup.", 9, 1) { Id = 13, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc)},
                    new Comment("Work file looks great!", 10, 3) { Id = 14, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Love the game review!", 11, 4) { Id = 15, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Nice recipe!", 12, 1) { Id = 16, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new Comment("Helpful notes!", 13, 3) { Id = 17, CreatedAt = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) }
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
                    new AuditLog(ChangeType.Updated, 9, 4) { Id = 9, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Created, 10, 5) { Id = 10, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) },
                    new AuditLog(ChangeType.Created, 11, 6) { Id = 11, Timestamp = DateTime.SpecifyKind(new DateTime(2024, 12, 24, 10, 0, 0), DateTimeKind.Utc) }
                });

            builder.Entity<UserSharedFolder>()
                .HasData(new List<UserSharedFolder>
                {
                    new UserSharedFolder { UserId = 1, FolderId = 2 },
                    new UserSharedFolder { UserId = 2, FolderId = 6 },
                    new UserSharedFolder { UserId = 3, FolderId = 4 },
                    new UserSharedFolder { UserId = 4, FolderId = 8 },
                    new UserSharedFolder { UserId = 1, FolderId = 10 },
                    new UserSharedFolder { UserId = 2, FolderId = 10 },
                    new UserSharedFolder { UserId = 3, FolderId = 2 },
                    new UserSharedFolder { UserId = 4, FolderId = 4 }
                });

            builder.Entity<UserSharedFile>()
                .HasData(new List<UserSharedFile>
                {
                    new UserSharedFile { UserId = 1, FileId = 2 },
                    new UserSharedFile { UserId = 2, FileId = 4 },
                    new UserSharedFile { UserId = 3, FileId = 6 },
                    new UserSharedFile { UserId = 4, FileId = 8 },
                    new UserSharedFile { UserId = 1, FileId = 10 },
                    new UserSharedFile { UserId = 2, FileId = 12 },
                    new UserSharedFile { UserId = 3, FileId = 4 },
                    new UserSharedFile { UserId = 4, FileId = 6 }
                });

        }
    }
}
