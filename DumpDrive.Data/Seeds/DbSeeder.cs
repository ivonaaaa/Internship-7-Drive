using DumpDrive.Data.Entities;
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
                    new User() { Id = 1, Email = "ivona@gmail.com", Password = "pass1", Username = "ivona" },
                    new User() { Id = 2, Email = "jure@gmail.com", Password = "pass2", Username = "jure" },
                    new User() { Id = 3, Email = "bruno@gmail.com", Password = "pass3", Username = "bruno" },
                    new User() { Id = 4, Email = "ana@gmail.com", Password = "pass4", Username = "ana" },
                    new User() { Id = 5, Email = "leo@ffst.hr", Password = "pass5", Username = "leo" },
                    new User() { Id = 6, Email = "hana@pmfst.chr", Password = "pass6", Username = "hana" }
                });

            builder.Entity<Folder>()
                .HasData(new List<Folder>
                {
                    new Folder() { Id = 1, Name = "Documents", OwnerId = 1, Status = SharedStatus.Private },
                    new Folder() { Id = 2, Name = "Photos", OwnerId = 2, Status = SharedStatus.Shared },
                    new Folder() { Id = 3, Name = "Music", OwnerId = 3, Status = SharedStatus.Private },
                    new Folder() { Id = 4, Name = "Videos", OwnerId = 4, Status = SharedStatus.Shared },
                    new Folder() { Id = 5, Name = "Projects", OwnerId = 3, Status = SharedStatus.Private },
                    new Folder() { Id = 6, Name = "Downloads", OwnerId = 2, Status = SharedStatus.Shared },
                    new Folder() { Id = 7, Name = "Archives", OwnerId = 1, Status = SharedStatus.Private },
                    new Folder() { Id = 8, Name = "Work", OwnerId = 5, Status = SharedStatus.Shared },
                    new Folder() { Id = 9, Name = "Games", OwnerId = 6, Status = SharedStatus.Private },
                    new Folder() { Id = 10, Name = "Recipes", OwnerId = 4, Status = SharedStatus.Shared },
                    new Folder() { Id = 11, Name = "Notes", OwnerId = 6, Status = SharedStatus.Private }
                });

            builder.Entity<DumpFile>()
                .HasData(new List<DumpFile>
                {
                    new DumpFile() { Id = 1, Name = "resume.pdf", Content = "My resume. Lorem ipsum.", FolderId = 1, Status = SharedStatus.Private },
                    new DumpFile() { Id = 2, Name = "holiday.jpg", Content = "Image of a holiday memory!", FolderId = 2, Status = SharedStatus.Shared },
                    new DumpFile() { Id = 3, Name = "song.mp3", Content = "Never Gonna Give You Up", FolderId = 3, Status = SharedStatus.Private },
                    new DumpFile() { Id = 4, Name = "movie.mp4", Content = "Movie: Interstellar", FolderId = 4, Status = SharedStatus.Shared },
                    new DumpFile() { Id = 5, Name = "project_plan.docx", Content = "Plan for a project.", FolderId = 5, Status = SharedStatus.Private },
                    new DumpFile() { Id = 6, Name = "presentation.pptx", Content = "A presentation about my project.", FolderId = 5, Status = SharedStatus.Shared },
                    new DumpFile() { Id = 7, Name = "report.pdf", Content = "Report number 6.", FolderId = 6, Status = SharedStatus.Private },
                    new DumpFile() { Id = 8, Name = "archive.zip", Content = "Here are saved some important documents.", FolderId = 7, Status = SharedStatus.Shared },
                    new DumpFile() { Id = 9, Name = "data.csv", Content = "Seed data for my database.", FolderId = 7, Status = SharedStatus.Private },
                    new DumpFile() { Id = 10, Name = "work_report.docx", Content = "Week 1: Number of working hours - 40\nWeek 2: Number of working hours - 38", FolderId = 8, Status = SharedStatus.Shared },
                    new DumpFile() { Id = 11, Name = "game_review.txt", Content = "The game was fun to play but too many bad huys to fight", FolderId = 9, Status = SharedStatus.Private },
                    new DumpFile() { Id = 12, Name = "recipe.pdf", Content = "Cookies: 2 eggs, flour, water, vanilla extract", FolderId = 10, Status = SharedStatus.Shared },
                    new DumpFile() { Id = 13, Name = "notes.txt", Content = "Lorem ipsum.", FolderId = 11, Status = SharedStatus.Private }
                });

            builder.Entity<Comment>()
                .HasData(new List<Comment>
                {
                    new Comment() { Id = 1, Content = "Great resume!", FileId = 1, UserId = 1},
                    new Comment() { Id = 2, Content = "Lovely picture!", FileId = 2, UserId = 2},
                    new Comment() { Id = 3, Content = "Nice music!", FileId = 3, UserId = 3 },
                    new Comment() { Id = 4, Content = "Cool video!", FileId = 4, UserId = 4 },
                    new Comment() { Id = 5, Content = "This resume could be better.", FileId = 1, UserId = 1 },
                    new Comment() { Id = 6, Content = "Beautiful image!", FileId = 2, UserId = 2 },
                    new Comment () { Id = 7, Content = "I don't like this song!", FileId = 3, UserId = 3 },
                    new Comment() { Id = 8, Content = "Amazing video!", FileId = 4, UserId = 4 },
                    new Comment() { Id = 9, Content = "Excellent project plan!", FileId = 5, UserId = 5 },
                    new Comment() { Id = 10, Content = "Great presentation!", FileId = 6, UserId = 6 },
                    new Comment() { Id = 11, Content = "Very detailed report!", FileId = 7, UserId = 7 },
                    new Comment() { Id = 12, Content = "Important archive data.", FileId = 8, UserId = 8 },
                    new Comment() { Id = 13, Content = "Data needs cleanup.", FileId = 9, UserId = 9 },
                    new Comment() { Id = 14, Content = "Work file looks great!", FileId = 10, UserId = 10 },
                    new Comment() { Id = 15, Content = "Love the game review!", FileId = 11, UserId = 11 },
                    new Comment() { Id = 16, Content = "Nice recipe!", FileId = 12, UserId = 12 },
                    new Comment() { Id = 17, Content = "Helpful notes!", FileId = 13, UserId = 13 }
                });

            builder.Entity<AuditLog>()
                .HasData(new List<AuditLog>
                {
                    new AuditLog() { Id = 1, ChangeType = ChangeType.Created, FileId = 1, ChangedByUserId = 1},
                    new AuditLog() { Id = 2, ChangeType = ChangeType.Created, FileId = 2, ChangedByUserId = 2 },
                    new AuditLog() { Id = 3, ChangeType = ChangeType.Updated, FileId = 3, ChangedByUserId = 3 },
                    new AuditLog() { Id = 4, ChangeType = ChangeType.Created, FileId = 4, ChangedByUserId = 4 },
                    new AuditLog() { Id = 5, ChangeType = ChangeType.Created, FileId = 5, ChangedByUserId = 5 },
                    new AuditLog() { Id = 6, ChangeType = ChangeType.Created, FileId = 6, ChangedByUserId = 6 },
                    new AuditLog() { Id = 7, ChangeType = ChangeType.Created, FileId = 7, ChangedByUserId = 7 },
                    new AuditLog() { Id = 8, ChangeType = ChangeType.Created, FileId = 8, ChangedByUserId = 8 },
                    new AuditLog() { Id = 9, ChangeType = ChangeType.Created, FileId = 9, ChangedByUserId = 9 },
                    new AuditLog() { Id = 10, ChangeType = ChangeType.Created, FileId = 10, ChangedByUserId = 10 },
                    new AuditLog() { Id = 11, ChangeType = ChangeType.Created, FileId = 11, ChangedByUserId = 11 }
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
