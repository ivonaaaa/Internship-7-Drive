using DumpDrive.Presentation.Factories;

namespace DumpDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            var homePageFactory = new LoginAndRegistration();
            var homePage = homePageFactory.CreateLoginAndRegisterMenu();
            homePage.Execute();
        }
    }
}
