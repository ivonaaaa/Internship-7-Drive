using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;
using DumpDrive.Domain.Factories;
using DumpDrive.Presentation.Factories;

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

                Console.WriteLine($"Attempting to log in with email: {email}");

                var user = userRepository.GetByEmailAndPassword(email, password);
                if (user != null)
                {
                    Console.WriteLine($"Login successful! Welcome, {user.Username}.\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    var mainMenu = new MainMenu(sharedRepository, driveRepository, userRepository, user.Id).CreateMainMenu();
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
