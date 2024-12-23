using System;

namespace DumpDrive.Data.Entities.Models
{
    public class DumpFile
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public DateTime LastChanged { get; private set; }
        public Guid FolderId { get; private set; }
        public Folder Folder { get; set; }
        public SharedStatus Status { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

        public DumpFile(string name, Guid folderId)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastChanged = DateTime.Now;
            FolderId = folderId;
            Status = SharedStatus.Private;
        }
    }
}
