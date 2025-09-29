
namespace DumpDrive.Data.Entities
{
    public class AuditLog
    {
        public int Id { get; set; }
        public ChangeType ChangeType { get; set; }
        public int FileId { get; set; }
        public DumpFile File { get; set; } = null!;
        public int ChangedByUserId { get; set; }
        public User ChangedByUser { get; set; } = null!;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
