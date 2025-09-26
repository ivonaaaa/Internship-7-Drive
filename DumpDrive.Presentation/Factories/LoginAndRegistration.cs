using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions;

namespace DumpDrive.Presentation.Factories
{
    public class LoginAndRegistration
    {
        private readonly UserRepository _userRepository;
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;

        public LoginAndRegistration(UserRepository userRepository, DriveRepository driveRepository, SharedRepository sharedRepository)
        {
            _userRepository = userRepository;
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
        }

        public IMenuAction CreateLoginAndRegisterMenu()
        {
            var menu = new BaseMenuAction
            {
                Name = "Login/Registration",
                Actions = new List<IAction>
                {
                    new Login(_userRepository, _driveRepository, _sharedRepository),
                    new Register(_userRepository),
                    new Exit()
                }
            };
            return menu;
        }
    }
}
