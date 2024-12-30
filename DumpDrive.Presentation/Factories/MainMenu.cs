using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Factories
{
    public class MainMenu
    {
        private readonly SharedRepository _sharedRepository;
        private readonly DriveRepository _driveRepository;
        private readonly UserRepository _userRepository;
        private readonly int _userId;

        public MainMenu(SharedRepository sharedRepository, DriveRepository driveRepository, UserRepository userRepository, int userId)
        {
            _sharedRepository = sharedRepository;
            _driveRepository = driveRepository;
            _userRepository = userRepository;
            _userId = userId;
        }

        public IMenuAction CreateMainMenu()
        {
            var menu = new MenuGenerator
            {
                Name = "Main",
                Actions = new List<IAction>
                {
                    new MyDrive(_driveRepository, _sharedRepository, _userRepository).Create(_userId),
                    new SharedWithMe(_sharedRepository).Create(_userId),
                    new ProfileSettings(_userRepository, _userId).Create(),
                    new Logout()
                }
            };

            return menu;
        }
    }
}
