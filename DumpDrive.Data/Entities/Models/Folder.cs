using System;

namespace DumpDrive.Data.Entities.Models
{
    public class Folder
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public Guid OwnerId { get; private set; }
        public User Owner { get; set; }
        public SharedStatus Status { get; set; }
        public List<DumpFile> Files { get; set; } = new List<DumpFile>();

        public Folder(string name, Guid ownerId)
        {
            Id = Guid.NewGuid();
            Name = name;
            OwnerId = ownerId;
            Status = SharedStatus.Private;
        }
    }
}
