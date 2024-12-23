using System;

public class Folder
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public Guid OwnerId { get; private set; }
    public User Owner { get; set; }
    public SharedStatus Status { get; set; }
    public List<File> Files { get; set; } = new List<File>();

    public Folder(string name, Guid ownerId)
    {
        Id = Guid.NewGuid();
        Name = name;
        OwnerId = ownerId;
        Status = SharedStatus.Private;
    }
}
