using Microsoft.EntityFrameworkCore;
using DumpDrive.Data.Entities;

namespace DumpDrive.Domain.Factories
{
    public static class DbContextFactory
    {
        public static DumpDriveDbContext GetDumpDriveDbContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseNpgsql("Host=localhost;Database=DumpDrive;User Id=postgres;Password=dumpbaze")
                .Options;

            return new DumpDriveDbContext(options);
        }
    }
}
