using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions.Menus.MyDrive;

namespace DumpDrive.Presentation.Factories
{
    public class MyDrive
    {
        private readonly DriveRepository _driveRepository;

        public MyDrive(DriveRepository driveRepository)
        {
            _driveRepository = driveRepository;
        }

        public IAction Create(int userId)
        {
            return new DisplayDriveContent(_driveRepository, userId);
        }
    }
}
