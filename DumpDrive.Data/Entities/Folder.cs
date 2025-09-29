using System;

namespace DumpDrive.Data.Entities
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int OwnerId { get; set; }
        public User Owner { get; set; } = null!;
        public SharedStatus Status { get; set; }
        public List<DumpFile> Files { get; set; } = new List<DumpFile>();
        public ICollection<UserSharedFolder> SharedUsers { get; set; } = new List<UserSharedFolder>();
    }
}
