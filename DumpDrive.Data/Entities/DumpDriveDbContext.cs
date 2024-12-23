using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<File> Files { get; set; }
    public DbSet<Folder> Folders { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Folder>()
            .HasOne(f => f.Owner)
            .WithMany(u => u.Folders)
            .HasForeignKey(f => f.OwnerId);

        modelBuilder.Entity<File>()
            .HasOne(f => f.Folder)
            .WithMany(f => f.Files)
            .HasForeignKey(f => f.FolderId);

        modelBuilder.Entity<Comment>()
            .HasOne(c => c.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.UserId);

        modelBuilder.Entity<Comment>()
            .HasOne(c => c.File)
            .WithMany(f => f.Comments)
            .HasForeignKey(c => c.FileId);

        modelBuilder.Entity<AuditLog>()
            .HasOne(a => a.File)
            .WithMany(f => f.AuditLogs)
            .HasForeignKey(a => a.FileId);

        modelBuilder.Entity<AuditLog>()
            .HasOne(a => a.ChangedByUser)
            .WithMany(u => u.AuditLogs)
            .HasForeignKey(a => a.ChangedByUserId);
    }
}
