using System;

public class AuditLog
{
    public Guid Id { get; private set; }
    public string ChangeType { get; set; }
    public Guid FileId { get; private set; }
    public File File { get; set; }
    public Guid ChangedByUserId { get; private set; }
    public User ChangedByUser { get; set; }
    public DateTime Timestamp { get; private set; }

    public AuditLog(string changeType, Guid fileId, Guid changedByUserId)
    {
        Id = Guid.NewGuid();
        ChangeType = changeType;
        FileId = fileId;
        ChangedByUserId = changedByUserId;
        Timestamp = DateTime.Now;
    }
}
