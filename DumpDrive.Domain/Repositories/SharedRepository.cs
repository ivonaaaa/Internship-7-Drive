using DumpDrive.Data.Entities;
using DumpDrive.Data.Entities.Models;
using DumpDrive.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace DumpDrive.Domain.Repositories
{
    public class SharedRepository : BaseRepository
    {
        public SharedRepository(DumpDriveDbContext dbcontext) : base(dbcontext)
        {
        }

        public IEnumerable<Folder> GetSharedFolders(int userId)
        {
            return DbContext.UserSharedFolders
            .Where(uf => uf.UserId == userId)
            .Select(uf => uf.Folder)
            .ToList();
        }

        public IEnumerable<DumpFile> GetSharedFiles(int userId)
        {
            return DbContext.UserSharedFiles
            .Where(uf => uf.UserId == userId)
            .Select(uf => uf.File)
            .ToList();
        }

        public IEnumerable<DumpFile> GetSharedFilesInFolder(int folderId, int userId)
        {
            return DbContext.UserSharedFiles
                .Where(uf => uf.UserId == userId && uf.File.FolderId == folderId)
                .Include(uf => uf.File)
                .Select(uf => uf.File)
                .ToList();
        }

        public ResponseResultType AddFolderShare(int folderId, int userId)
        {
            var user = DbContext.Users.FirstOrDefault(u => u.Id == userId);
            var folder = DbContext.Folders.FirstOrDefault(f => f.Id == folderId);

            if (user == null || folder == null)
                return ResponseResultType.NotFound;

            var existingEntry = DbContext.UserSharedFolders
                .FirstOrDefault(uf => uf.FolderId == folderId && uf.UserId == userId);

            if (existingEntry != null)
                return ResponseResultType.NoChanges;

            var shareEntry = new UserSharedFolder { FolderId = folderId, UserId = userId };
            DbContext.UserSharedFolders.Add(shareEntry);

            var filesInFolder = DbContext.Files.Where(f => f.FolderId == folderId).ToList();
            foreach (var file in filesInFolder)
            {
                var fileShareEntry = new UserSharedFile { FileId = file.Id, UserId = userId };
                DbContext.UserSharedFiles.Add(fileShareEntry);
            }

            return SaveChanges();
        }

        public ResponseResultType AddFileShare(int fileId, int userId)
        {
            var shareEntry = new UserSharedFile { FileId = fileId, UserId = userId };
            DbContext.UserSharedFiles.Add(shareEntry);

            return SaveChanges();
        }

        public ResponseResultType RemoveFolderShare(int folderId, int userId)
        {
            var share = DbContext.UserSharedFolders
                                .FirstOrDefault(fs => fs.FolderId == folderId && fs.UserId == userId);

            if (share != null)
            {
                DbContext.UserSharedFolders.Remove(share);
                DbContext.SaveChanges();
                return ResponseResultType.Success;
            }

            return ResponseResultType.NotFound;
        }

        public ResponseResultType RemoveFileShare(int fileId, int userId)
        {
            var share = DbContext.UserSharedFiles
                                 .FirstOrDefault(fs => fs.FileId == fileId && fs.UserId == userId);

            if (share != null)
            {
                DbContext.UserSharedFiles.Remove(share);
                DbContext.SaveChanges();
                return ResponseResultType.Success;
            }

            return ResponseResultType.NotFound;
        }

        public ResponseResultType RemoveFolderFromView(int folderId, int userId)
        {
            var share = DbContext.UserSharedFolders.FirstOrDefault(fs => fs.FolderId == folderId && fs.UserId == userId);

            if (share == null)
                return ResponseResultType.NotFound;

            var sharedFiles = DbContext.UserSharedFiles
                .Where(uf => uf.File.FolderId == folderId && uf.UserId == userId)
                .ToList();

            DbContext.UserSharedFiles.RemoveRange(sharedFiles);

            DbContext.UserSharedFolders.Remove(share);

            return SaveChanges();
        }

        public IEnumerable<Comment> GetComments(int fileId)
        {
            return DbContext.Comments
                .Where(c => c.FileId == fileId)
                .OrderByDescending(c => c.CreatedAt)
                .ToList();
        }

        public ResponseResultType AddComment(int fileId, int userId, string content)
        {
            var file = DbContext.Files.FirstOrDefault(f => f.Id == fileId);

            if (file == null)
                return ResponseResultType.NotFound;

            var comment = new Comment(content, fileId, userId);
            DbContext.Comments.Add(comment);
            DbContext.SaveChanges();

            return ResponseResultType.Success;
        }

        public ResponseResultType UpdateComment(int commentId, string newContent)
        {
            var comment = DbContext.Comments.FirstOrDefault(c => c.Id == commentId);

            if (comment == null)
                return ResponseResultType.NotFound;

            comment.Content = newContent;
            comment.CreatedAt = DateTime.Now;
            return SaveChanges();
        }

        public ResponseResultType DeleteComment(int commentId)
        {
            var comment = DbContext.Comments.FirstOrDefault(c => c.Id == commentId);

            if (comment == null)
                return ResponseResultType.NotFound;

            DbContext.Comments.Remove(comment);
            return SaveChanges();
        }

        public IEnumerable<DumpFile> GetFilesInFolder(int folderId, int userId)
        {
            return DbContext.Files
                .Where(f => f.FolderId == folderId && DbContext.UserSharedFiles.Any(sf => sf.FileId == f.Id && sf.UserId == userId))
                .ToList();
        }

        public ResponseResultType UpdateFileContent(int fileId, string newContent)
        {
            var file = DbContext.Files.FirstOrDefault(f => f.Id == fileId);

            if (file == null)
                return ResponseResultType.NotFound;

            file.Content = newContent;
            return SaveChanges();
        }

        public string GetFileContent(int fileId)
        {
            var file = DbContext.Files.FirstOrDefault(f => f.Id == fileId);

            return file?.Content ?? string.Empty;
        }

    }
}
