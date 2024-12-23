using System;

public class File
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public DateTime LastChanged { get; private set; }
    public Guid FolderId { get; private set; }
    public Folder Folder { get; set; }
    public SharedStatus Status { get; set; }

    public File(string name, Guid folderId)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastChanged = DateTime.Now;
        FolderId = folderId;
        Status = SharedStatus.Private;
    }
}
