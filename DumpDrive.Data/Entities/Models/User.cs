using System;

namespace DumpDrive.Data.Entities.Models
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public ICollection<Folder> Folders { get; set; } = new List<Folder>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

        public User(string email, string password, string username)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
            Username = username;
        }
    }
}
