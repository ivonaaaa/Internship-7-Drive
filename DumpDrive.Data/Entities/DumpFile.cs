
namespace DumpDrive.Data.Entities
{
    public class DumpFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime LastChanged { get; set; } = DateTime.UtcNow;
        public int FolderId { get; set; }
        public Folder? Folder { get; set; }
        public SharedStatus Status { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
        public ICollection<UserSharedFile> SharedUsers { get; set; } = new List<UserSharedFile>();
    }
}
