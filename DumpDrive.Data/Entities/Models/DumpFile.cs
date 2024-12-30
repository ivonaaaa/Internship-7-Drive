using System;

namespace DumpDrive.Data.Entities.Models
{
    public class DumpFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastChanged { get; set; }
        public int FolderId { get; set; }
        public Folder? Folder { get; set; }
        public SharedStatus Status { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
        public ICollection<UserSharedFile> SharedUsers { get; set; } = new List<UserSharedFile>();

        public DumpFile(string name, int folderId)
        {
            Name = name;
            LastChanged = DateTime.Now;
            FolderId = folderId;
            Status = SharedStatus.Private;
        }
    }
}
