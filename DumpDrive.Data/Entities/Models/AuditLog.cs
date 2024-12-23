using System;

namespace DumpDrive.Data.Entities.Models
{
    public class AuditLog
    {
        public Guid Id { get; set; }
        public ChangeType ChangeType { get; set; }
        public Guid FileId { get; set; }
        public DumpFile File { get; set; }
        public Guid ChangedByUserId { get; set; }
        public User ChangedByUser { get; set; }
        public DateTime Timestamp { get; set; }

        public AuditLog(ChangeType changeType, Guid fileId, Guid changedByUserId)
        {
            Id = Guid.NewGuid();
            ChangeType = changeType;
            FileId = fileId;
            ChangedByUserId = changedByUserId;
            Timestamp = DateTime.Now;
        }
    }
}
