using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DumpDrive.Data.Seeds;
using Microsoft.Extensions.Configuration;
using DumpDrive.Data.Entities;

namespace DumpDrive.Data
{
    public class DumpDriveDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<DumpFile> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<UserSharedFolder> UserSharedFolders { get; set; }
        public DbSet<UserSharedFile> UserSharedFiles { get; set; }

        public DumpDriveDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Folder>()
                .HasOne(f => f.Owner)
                .WithMany(u => u.Folders)
                .HasForeignKey(f => f.OwnerId);

            modelBuilder.Entity<DumpFile>()
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

            modelBuilder.Entity<UserSharedFolder>()
                .HasKey(usf => new { usf.UserId, usf.FolderId });

            modelBuilder.Entity<UserSharedFolder>()
                .HasOne(usf => usf.User)
                .WithMany(u => u.SharedFolders)
                .HasForeignKey(usf => usf.UserId);

            modelBuilder.Entity<UserSharedFolder>()
                .HasOne(usf => usf.Folder)
                .WithMany(f => f.SharedUsers)
                .HasForeignKey(usf => usf.FolderId);

            modelBuilder.Entity<UserSharedFile>()
                .HasKey(usf => new { usf.UserId, usf.FileId });

            modelBuilder.Entity<UserSharedFile>()
                .HasOne(usf => usf.User)
                .WithMany(u => u.SharedFiles)
                .HasForeignKey(usf => usf.UserId);

            modelBuilder.Entity<UserSharedFile>()
                .HasOne(usf => usf.File)
                .WithMany(f => f.SharedUsers)
                .HasForeignKey(usf => usf.FileId);

            DbSeeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DumpDriveDbContextFactory : IDesignTimeDbContextFactory<DumpDriveDbContext>
    {
        public DumpDriveDbContext CreateDbContext(string[] args)
        {
            var configFilePath = Path.Combine(AppContext.BaseDirectory, "App.config.xml");

            if (!File.Exists(configFilePath))
                throw new FileNotFoundException($"Configuration file '{configFilePath}' not found.");

            if (!File.Exists(configFilePath))
                throw new FileNotFoundException($"Configuration file '{configFilePath}' not found.");

            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddXmlFile(configFilePath)
                .Build();

            config.Providers
                .First()
                .TryGet("connectionStrings:add:DumpDrive:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<DumpDriveDbContext>()
                .UseNpgsql(connectionString)
                .Options;

            return new DumpDriveDbContext(options);
        }
    }

}
