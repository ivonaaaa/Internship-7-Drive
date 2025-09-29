using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpDrive.Data.Entities
{
    public class UserSharedFolder
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int FolderId { get; set; }
        public Folder Folder { get; set; }
    }
}
