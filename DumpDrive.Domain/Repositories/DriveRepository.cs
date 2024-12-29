using DumpDrive.Data.Entities.Models;
using DumpDrive.Data.Entities;
using DumpDrive.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace DumpDrive.Domain.Repositories
{
    public class DriveRepository : BaseRepository
    {
        public DriveRepository(DumpDriveDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Folder> GetUserFolders(int userId)
        {
            var folders = DbContext.Folders
                .Where(f => f.OwnerId == userId)
                .Include(f => f.Files)
                .OrderBy(f => f.Name)
                .ToList();

            return folders.Select(f => new Folder(f.Name, f.OwnerId)
            {
                Id = f.Id,
                Status = f.Status,
                Files = f.Files.ToList()
            }).ToList();
        }


        public ICollection<DumpFile> GetFolderFiles(int folderId)
        {
            return DbContext.Files
                .Where(f => f.FolderId == folderId)
                .Select(f => new DumpFile(f.Name, f.FolderId)
                {
                    Id = f.Id,
                    LastChanged = f.LastChanged,
                    Status = f.Status
                })
                .OrderByDescending(f => f.LastChanged)
                .ToList();
        }

        public ResponseResultType CreateFolder(int userId, string folderName)
        {
            var isDuplicate = DbContext.Folders.Any(f => f.OwnerId == userId && f.Name == folderName);
            if (isDuplicate) return ResponseResultType.AlreadyExists;

            var folder = new Folder(folderName, userId);
            DbContext.Folders.Add(folder);

            return SaveChanges();
        }

        public ResponseResultType CreateFile(int folderId, string fileName)
        {
            var isDuplicate = DbContext.Files.Any(f => f.FolderId == folderId && f.Name == fileName);
            if (isDuplicate) return ResponseResultType.AlreadyExists;

            var file = new DumpFile(fileName, folderId);
            DbContext.Files.Add(file);

            return SaveChanges();
        }

        public ResponseResultType DeleteFolder(int folderId)
        {
            var folder = DbContext.Folders
                .Where(f => f.Id == folderId)
                .Include(f => f.Files)
                .FirstOrDefault();

            if (folder == null) return ResponseResultType.NotFound;

            DbContext.Files.RemoveRange(folder.Files);
            DbContext.Folders.Remove(folder);

            return SaveChanges();
        }

        public ResponseResultType DeleteFile(int fileId)
        {
            var file = DbContext.Files.FirstOrDefault(f => f.Id == fileId);
            if (file == null) return ResponseResultType.NotFound;

            DbContext.Files.Remove(file);
            return SaveChanges();
        }

        public ResponseResultType RenameFolder(int folderId, string newName)
        {
            var folder = DbContext.Folders.FirstOrDefault(f => f.Id == folderId);
            if (folder == null) return ResponseResultType.NotFound;

            var isDuplicate = DbContext.Folders.Any(f => f.OwnerId == folder.OwnerId && f.Name == newName);
            if (isDuplicate) return ResponseResultType.AlreadyExists;

            folder.Name = newName;
            return SaveChanges();
        }

        public ResponseResultType RenameFile(int fileId, string newName)
        {
            var file = DbContext.Files.FirstOrDefault(f => f.Id == fileId);
            if (file == null) return ResponseResultType.NotFound;

            var isDuplicate = DbContext.Files.Any(f => f.FolderId == file.FolderId && f.Name == newName);
            if (isDuplicate) return ResponseResultType.AlreadyExists;

            file.Name = newName;
            file.LastChanged = DateTime.Now;
            return SaveChanges();
        }
    }
}
