using System;

namespace DumpDrive.Data.Entities.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public User? Owner { get; set; }
        public SharedStatus Status { get; set; }
        public List<DumpFile> Files { get; set; } = new List<DumpFile>();

        public Folder(string name, int ownerId)
        {
            Name = name;
            OwnerId = ownerId;
            Status = SharedStatus.Private;
        }
    }
}
