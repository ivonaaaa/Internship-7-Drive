using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DumpDrive.Data.Entities;

namespace DumpDrive.Domain.Factories
{
    public static class DumpDriveDbContextFactory
    {
        public static DumpDriveDbContext GetDumpDriveDbContext()
        {
            var options = new DbContextOptionsBuilder<DumpDriveDbContext>()
                .UseNpgsql(ConfigurationManager.ConnectionStrings["DumpDrive"].ConnectionString)
                .Options;

            return new DumpDriveDbContext(options);
        }
    }
}
