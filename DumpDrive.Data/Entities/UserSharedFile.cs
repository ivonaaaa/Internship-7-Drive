
namespace DumpDrive.Data.Entities
{
    public class UserSharedFile
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int FileId { get; set; }
        public DumpFile File { get; set; }
    }
}
