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

            while (true)
            {
                string email;
                if (!Reader.TryReadLine("Enter your email: ", out email) || !ValidationHelper.IsValidEmail(email))
                {
                    Console.WriteLine("Invalid email format. Please try again.");
                    continue;
                }

                string password;
                if (!Reader.TryReadLine("Enter your password: ", out password))
                {
                    Console.WriteLine("Password cannot be empty.");
                    continue;
                }

                Console.WriteLine($"Attempting to log in with email: {email}");

                var user = userRepository.GetByEmailAndPassword(email, password);
                if (user != null)
                {
                    Console.WriteLine($"Login successful! Welcome, {user.Username}.\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    var mainMenu = new MainMenu();
                    mainMenu.Execute();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid email or password. You must wait 30 seconds before trying again.");
                    Thread.Sleep(30000);
                }
            }
        }
    }
}
