using System;

namespace DumpDrive.Data.Entities.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid FileId { get; set; }
        public DumpFile File { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }

        public Comment(string content, Guid fileId, Guid userId)
        {
            Id = Guid.NewGuid();
            Content = content;
            FileId = fileId;
            UserId = userId;
            CreatedAt = DateTime.Now;
        }
    }
}
