using System;

public class Comment
{
    public Guid Id { get; private set; }
    public string Content { get; set; }
    public Guid FileId { get; private set; }
    public File File { get; set; }
    public Guid UserId { get; private set; }
    public User User { get; set; }
    public DateTime CreatedAt { get; private set; }

    public Comment(string content, Guid fileId, Guid userId)
    {
        Id = Guid.NewGuid();
        Content = content;
        FileId = fileId;
        UserId = userId;
        CreatedAt = DateTime.Now;
    }
}
