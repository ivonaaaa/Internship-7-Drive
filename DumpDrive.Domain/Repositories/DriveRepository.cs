using DumpDrive.Data.Entities;
using DumpDrive.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using DumpDrive.Data;

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

            return folders.Select(f => new Folder
            {
                Id = f.Id,
                Name  = f.Name,
                Status = f.Status,
                Files = f.Files.ToList()
            }).ToList();
        }

        public ICollection<DumpFile> GetFolderFiles(int folderId)
        {
            return DbContext.Files
                .Where(f => f.FolderId == folderId)
                .Select(f => new DumpFile()
                {
                    Id = f.Id,
                    Name = f.Name,
                    Content = f.Content,
                    LastChanged = f.LastChanged,
                    Status = f.Status
                })
                .OrderByDescending(f => f.LastChanged)
                .ToList();
        }

        public Folder? GetFolderByName(int userId, string folderName)
        {
            return DbContext.Folders
                .Where(f => f.OwnerId == userId && f.Name.ToLower() == folderName.ToLower())
                .FirstOrDefault();
        }

        public DumpFile? GetFileByName(int userId, string fileName)
        {
            return DbContext.Files
                .Where(f => f.Folder.OwnerId == userId && f.Name.ToLower() == fileName.ToLower())
                .FirstOrDefault();
        }

        public ResponseResultType CreateFolder(int userId, string folderName)
        {
            var isDuplicate = DbContext.Folders.Any(f => f.OwnerId == userId && f.Name == folderName);
            if (isDuplicate) return ResponseResultType.AlreadyExists;

            var folder = new Folder();
            DbContext.Folders.Add(folder);

            return SaveChanges();
        }

        public ResponseResultType CreateFile(int folderId, string fileName)
        {
            var folderExists = DbContext.Folders.Any(f => f.Id == folderId);
            if (!folderExists) return ResponseResultType.NotFound;

            var isDuplicate = DbContext.Files.Any(f => f.FolderId == folderId && f.Name.ToLower() == fileName.ToLower());
            if (isDuplicate) return ResponseResultType.AlreadyExists;

            var file = new DumpFile()
            {
                Name = fileName,
                Content = "",
                Status = SharedStatus.Private,
                FolderId = folderId,
            };
            DbContext.Files.Add(file);

            var sharedUsers = DbContext.UserSharedFolders
                .Where(uf => uf.FolderId == folderId)
                .Select(uf => uf.UserId)
                .ToList();

            foreach (var sharedUserId in sharedUsers)
            {
                DbContext.UserSharedFiles.Add(new UserSharedFile
                {
                    File = file,
                    UserId = sharedUserId
                });
            }

            DbContext.SaveChanges();

            return ResponseResultType.Success;
        }

        public ResponseResultType UpdateFileContent(int fileId, string newContent)
        {
            var file = DbContext.Files.FirstOrDefault(f => f.Id == fileId);
            if (file == null)
                return ResponseResultType.Failure;

            file.Content = newContent.Replace("\0", "");
            file.LastChanged = DateTime.UtcNow;

            DbContext.SaveChanges();
            return ResponseResultType.Success;
        }

        public ResponseResultType DeleteFolder(int userId, string folderName)
        {
            var folder = DbContext.Folders.FirstOrDefault(f => f.OwnerId == userId && f.Name.ToLower() == folderName.ToLower());

            if (folder == null)
                return ResponseResultType.NotFound;

            DbContext.Folders.Remove(folder);
            DbContext.SaveChanges();
            return ResponseResultType.Success;
        }

        public ResponseResultType DeleteFile(int userId, string fileName)
        {
            var file = DbContext.Files
                .FirstOrDefault(f => f.Folder.OwnerId == userId &&
                                     f.Name.ToLower() == fileName.ToLower());

            if (file == null)
                return ResponseResultType.NotFound;

            DbContext.Files.Remove(file);
            DbContext.SaveChanges();
            return ResponseResultType.Success;
        }

        public ResponseResultType RenameFolder(int userId, string oldName, string newName)
        {
            var folder = DbContext.Folders
                .FirstOrDefault(f => f.OwnerId == userId && f.Name.ToLower() == oldName.ToLower());

            if (folder == null)
                return ResponseResultType.NotFound;

            folder.Name = newName;
            DbContext.SaveChanges();
            return ResponseResultType.Success;
        }

        public ResponseResultType RenameFile(int userId, string oldName, string newName)
        {
            var file = DbContext.Files.FirstOrDefault(f => f.Folder.OwnerId == userId && f.Name.ToLower() == oldName.ToLower());

            if (file == null)
                return ResponseResultType.NotFound;

            file.Name = newName;
            DbContext.SaveChanges();
            return ResponseResultType.Success;
        }
    }
}
