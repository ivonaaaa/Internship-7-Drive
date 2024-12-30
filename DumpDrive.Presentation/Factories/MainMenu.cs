using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Factories
{
    public class MainMenu
    {
        private readonly DriveRepository _driveRepository;
        private readonly UserRepository _userRepository;
        private readonly int _userId;

        public MainMenu(DriveRepository driveRepository, UserRepository userRepository, int userId)
        {
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
                    new MyDrive(_driveRepository).Create(_userId),
                    //new SharedWithMe(),
                    new ProfileSettings(_userRepository, _userId).Create(),
                    new Logout()
                }
            };

            return menu;
        }
    }
}
