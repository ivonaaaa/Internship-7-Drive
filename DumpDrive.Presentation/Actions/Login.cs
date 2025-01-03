using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;
using DumpDrive.Domain.Factories;
using DumpDrive.Presentation.Factories;
using DumpDrive.Presentation.Actions.Menus;
using DumpDrive.Data.Entities.Models;

namespace DumpDrive.Presentation.Actions
{
    public class Login : IAction
    {
        public string Name { get; set; } = "Login";

        public void Execute()
        {
            var userRepository = RepositoryFactory.Create<UserRepository>();
            var driveRepository = RepositoryFactory.Create<DriveRepository>();
            var sharedRepository = RepositoryFactory.Create<SharedRepository>();

            while (true)
            {
                string email = Reader.ReadEmail();
                string password = Reader.ReadPassword();

                Console.WriteLine($"\nAttempting to log in...");

                var user = userRepository.GetByEmailAndPassword(email, password);
                if (user != null)
                {
                    Console.WriteLine($"Login successful! Welcome, {user.Username}.\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    var jointActions = new JointActions(user.Id, driveRepository, sharedRepository);
                    var mainMenu = new MainMenu(userRepository, user.Id, driveRepository, sharedRepository, jointActions).CreateMainMenu();
                    mainMenu.Execute();

                    break;
                }
                else
                {
                    Writer.Error("Invalid email or password. You must wait 30 seconds before trying again.");
                    Thread.Sleep(30000);
                }
            }
        }
    }
}
