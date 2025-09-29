
namespace DumpDrive.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Username { get; set; } = null!;

        public ICollection<Folder> Folders { get; set; } = new List<Folder>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
        public ICollection<UserSharedFolder> SharedFolders { get; set; } = new List<UserSharedFolder>();
        public ICollection<UserSharedFile> SharedFiles { get; set; } = new List<UserSharedFile>();
    }
}
