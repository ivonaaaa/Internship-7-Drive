using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Factories
{
    public class LoginAndRegistration
    {
        public IMenuAction CreateLoginAndRegisterMenu()
        {
            var menu = new MenuGenerator
            {
                Name = "Login/Registration",
                Actions = new List<IAction>
                {
                    new Login(),
                    new Register(),
                    new Exit()
                }
            };
            return menu;
        }
    }
}
