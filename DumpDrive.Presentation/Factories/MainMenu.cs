using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions;
using DumpDrive.Presentation.Actions.Menus;

namespace DumpDrive.Presentation.Factories
{
    public class MainMenu
    {
        private readonly UserRepository _userRepository;
        private readonly int _userId;
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;
        private readonly JointActions _jointActions;

        public MainMenu(UserRepository userRepository, int userId, DriveRepository driveRepository, SharedRepository sharedRepository, JointActions jointActions)
        {
            _userRepository = userRepository;
            _userId = userId;
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
            _jointActions = jointActions;
        }

        public IMenuAction CreateMainMenu()
        {
            var menu = new BaseMenuAction
            {
                Name = "Main",
                Actions = new List<IAction>
                {
                    new MyDrive(_userRepository, _userId, _driveRepository, _sharedRepository, _jointActions).Create(_userId),
                    new SharedWithMe(_userId, _sharedRepository, _jointActions).Create(_userId),
                    new ProfileSettings(_userRepository, _userId).Create(),
                    new Logout(_userRepository, _driveRepository, _sharedRepository)
                }
            };

            return menu;
        }
    }
}
