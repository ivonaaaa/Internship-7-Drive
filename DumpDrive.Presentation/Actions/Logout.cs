using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpDrive.Presentation.Actions
{
    public class Logout : IAction
    {
        public string Name => "Logout";

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("\nYou have been logged out successfully." +
                "\n\nPress any key to continue...");
            Console.ReadKey();

            var homePageFactory = new LoginAndRegistration();
            var homePage = homePageFactory.CreateLoginAndRegisterMenu();
            homePage.Execute();
        }
    }
}
