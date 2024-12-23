using Microsoft.EntityFrameworkCore;
using DumpDrive.Data.Entities.Models;

namespace DumpDrive.Data.Seeds
{
    public static class DbSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            var ivonaId = Guid.NewGuid();
            var jureId = Guid.NewGuid();
            var brunoId = Guid.NewGuid();
            var anaId = Guid.NewGuid();

            builder.Entity<User>()
                .HasData(new List<User>
                {
                new User("ivona@gmail.com", "password123", "ivona") { Id = ivonaId },
                new User("jure@gmail.com", "password456", "jure") { Id = jureId },
                new User("bruno@gmail.com", "pass9", "bruno") { Id = brunoId },
                new User("ana@gmail.com", "pass7", "ana") { Id = anaId }
                });

            var folder1Id = Guid.NewGuid();
            var folder2Id = Guid.NewGuid();
            var folder3Id = Guid.NewGuid();
            var folder4Id = Guid.NewGuid();
            var folder5Id = Guid.NewGuid();
            var folder6Id = Guid.NewGuid();
            var folder7Id = Guid.NewGuid();

            builder.Entity<Folder>()
                .HasData(new List<Folder>
                {
                new Folder("Documents", ivonaId) { Id = folder1Id, Status = SharedStatus.Private },
                new Folder("Photos", jureId) { Id = folder2Id, Status = SharedStatus.Shared },
                new Folder("Music", brunoId) { Id = folder3Id, Status = SharedStatus.Private },
                new Folder("Videos", anaId) { Id = folder4Id, Status = SharedStatus.Shared },
                new Folder("Projects", brunoId) { Id = folder5Id, Status = SharedStatus.Private },
                new Folder("Downloads", jureId) { Id = folder6Id, Status = SharedStatus.Shared },
                new Folder("Archives", ivonaId) { Id = folder7Id, Status = SharedStatus.Private }
                });

            var file1Id = Guid.NewGuid();
            var file2Id = Guid.NewGuid();
            var file3Id = Guid.NewGuid();
            var file4Id = Guid.NewGuid();
            var file5Id = Guid.NewGuid();
            var file6Id = Guid.NewGuid();
            var file7Id = Guid.NewGuid();
            var file8Id = Guid.NewGuid();
            var file9Id = Guid.NewGuid();

            builder.Entity<File>()
                .HasData(new List<File>
                {
                new File("resume.pdf", folder1Id) { Id = file1Id, Status = SharedStatus.Private },
                new File("holiday.jpg", folder2Id) { Id = file2Id, Status = SharedStatus.Shared },
                new File("song.mp3", folder3Id) { Id = file3Id, Status = SharedStatus.Private },
                new File("movie.mp4", folder4Id) { Id = file4Id, Status = SharedStatus.Shared },
                new File("project_plan.docx", folder5Id) { Id = file5Id, Status = SharedStatus.Private },
                new File("presentation.pptx", folder5Id) { Id = file6Id, Status = SharedStatus.Shared },
                new File("report.pdf", folder6Id) { Id = file7Id, Status = SharedStatus.Private },
                new File("archive.zip", folder7Id) { Id = file8Id, Status = SharedStatus.Shared },
                new File("data.csv", folder7Id) { Id = file9Id, Status = SharedStatus.Private }
                });

            builder.Entity<Comment>()
                .HasData(new List<Comment>
                {
                new Comment("Great resume!", file1Id, ivonaId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Lovely picture!", file2Id, jureId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Nice music!", file3Id, brunoId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Cool video!", file4Id, anaId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("This resume could be better.", file1Id, anaId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Beautiful image!", file2Id, brunoId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("I dont like this song!", file3Id, brunoId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Amazing video!", file4Id, jureId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Excellent project plan!", file5Id, jureId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Great presentation!", file6Id, anaId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Very detailed report!", file7Id, ivonaId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Important archive data.", file8Id, jureId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now },
                new Comment("Data needs cleanup.", file9Id, ivonaId) { Id = Guid.NewGuid(), CreatedAt = DateTime.Now }
                });

            builder.Entity<AuditLog>()
                .HasData(new List<AuditLog>
                {
                new AuditLog("Created", file1Id, ivonaId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now },
                new AuditLog("Created", file2Id, jureId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now },
                new AuditLog("Updated", file3Id, brunoId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now },
                new AuditLog("Created", file4Id, anaId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now },
                new AuditLog("Created", file5Id, jureId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now },
                new AuditLog("Updated", file6Id, brunoId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now },
                new AuditLog("Created", file7Id, ivonaId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now },
                new AuditLog("Created", file8Id, brunoId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now },
                new AuditLog("Updated", file9Id, anaId) { Id = Guid.NewGuid(), Timestamp = DateTime.Now }
                });
        }
    }
}
