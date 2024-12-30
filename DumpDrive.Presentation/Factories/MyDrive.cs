using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions.Menus.MyDrive;

namespace DumpDrive.Presentation.Factories
{
    public class MyDrive
    {
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;
        private readonly UserRepository _userRepository;

        public MyDrive(DriveRepository driveRepository, SharedRepository sharedRepository, UserRepository userRepository)
        {
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
            _userRepository = userRepository;
        }

        public IAction Create(int userId)
        {
            return new HandleDriveContent(_driveRepository, _sharedRepository, _userRepository, userId);
        }
    }
}
