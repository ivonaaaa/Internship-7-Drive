using DumpDrive.Domain.Repositories;
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
        private readonly UserRepository _userRepository;
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;

        public string Name => "Logout";

        public Logout(UserRepository userRepository, DriveRepository driveRepository, SharedRepository sharedRepository)
        {
            _userRepository = userRepository;
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
        }

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("\nYou have been logged out successfully." +
                "\n\nPress any key to continue...");
            Console.ReadKey();

            var homePageFactory = new LoginAndRegistration(_userRepository, _driveRepository, _sharedRepository);
            var homePage = homePageFactory.CreateLoginAndRegisterMenu();
            homePage.Execute();
        }
    }
}
