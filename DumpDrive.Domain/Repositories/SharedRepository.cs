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
            return DbContext.Set<Folder>()
                .Include(f => f.Owner)
                .Include(f => f.Files)
                .Where(f => f.Status == SharedStatus.Shared && f.OwnerId != userId)
                .ToList();
        }

        public IEnumerable<DumpFile> GetSharedFiles(int userId)
        {
            return DbContext.Set<DumpFile>()
                .Include(df => df.Folder)
                .Where(df => df.Status == SharedStatus.Shared && df.Folder.OwnerId != userId)
                .ToList();
        }

        public ResponseResultType ShareFolder(int folderId, int userId)
        {
            var folder = DbContext.Set<Folder>().Find(folderId);
            if (folder == null)
                return ResponseResultType.NotFound;

            folder.Status = SharedStatus.Shared;
            DbContext.SaveChanges();
            return ResponseResultType.Success;
        }

        public ResponseResultType ShareFile(int fileId, int userId)
        {
            var file = DbContext.Set<DumpFile>().Find(fileId);
            if (file == null)
                return ResponseResultType.NotFound;

            file.Status = SharedStatus.Shared;
            DbContext.SaveChanges();
            return ResponseResultType.Success;
        }

        public ResponseResultType UnshareFolder(int folderId)
        {
            var folder = DbContext.Set<Folder>().Find(folderId);
            if (folder == null)
                return ResponseResultType.NotFound;

            folder.Status = SharedStatus.Private;
            DbContext.SaveChanges();
            return ResponseResultType.Success;
        }

        public ResponseResultType UnshareFile(int fileId)
        {
            var file = DbContext.Set<DumpFile>().Find(fileId);
            if (file == null)
                return ResponseResultType.NotFound;

            file.Status = SharedStatus.Private;
            DbContext.SaveChanges();
            return ResponseResultType.Success;
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
    }
}
