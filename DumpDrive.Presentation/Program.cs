using DumpDrive.Presentation.Factories;

namespace DumpDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuFactory = new LoginAndRegistration();
            var mainMenu = menuFactory.CreateLoginAndRegisterMenu();
            mainMenu.Execute();
        }
    }
}
