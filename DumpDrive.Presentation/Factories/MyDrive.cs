using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions.Menus;
using DumpDrive.Presentation.Actions.Menus.MyDrive;

namespace DumpDrive.Presentation.Factories
{
    public class MyDrive
    {
        private readonly UserRepository _userRepository;
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;
        private readonly JointActions _jointActions;

        public MyDrive(UserRepository userRepository, int userId, DriveRepository driveRepository, SharedRepository sharedRepository, JointActions jointActions)
        {
            _userRepository = userRepository;
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
            _jointActions = jointActions;
        }

        public IAction Create(int userId)
        {
            return new HandleDriveContent(_userRepository, userId, _driveRepository, _sharedRepository, _jointActions);
        }
    }
}
