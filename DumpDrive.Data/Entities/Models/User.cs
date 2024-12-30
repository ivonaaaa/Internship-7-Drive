using System;

namespace DumpDrive.Data.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public ICollection<Folder> Folders { get; set; } = new List<Folder>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
        public ICollection<UserSharedFolder> SharedFolders { get; set; } = new List<UserSharedFolder>();
        public ICollection<UserSharedFile> SharedFiles { get; set; } = new List<UserSharedFile>();

        public User(string email, string password, string username)
        {
            Email = email;
            Password = password;
            Username = username;
        }
    }
}
