using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions.Menus.ProfileSettings;

namespace DumpDrive.Presentation.Factories
{
    public class ProfileSettings
    {
        private readonly UserRepository _userRepository;
        private readonly int _userId;

        public ProfileSettings(UserRepository userRepository, int userId)
        {
            _userRepository = userRepository;
            _userId = userId;
        }

        public IMenuAction Create()
        {
            var menu = new BaseMenuAction
            {
                Name = "Profile Settings",
                Actions = new List<IAction>
                {
                    new ChangeEmail(_userRepository, _userId),
                    new ChangePassword(_userRepository, _userId)
                },
                CanGoBack = true
            };

            return menu;
        }
    }
}
