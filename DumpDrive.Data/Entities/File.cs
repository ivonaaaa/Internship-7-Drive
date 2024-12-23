using System;

public class File
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public DateTime LastChanged { get; private set; }
    public Guid OwnerId { get; private set; }
    public User Owner { get; set; }
    public SharedStatus Status { get; set; }

    public File(string name, Guid ownerId)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastChanged = DateTime.Now;
        OwnerId = ownerId;
        Status = SharedStatus.Private;
    }
}
