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

            string email;
            while (true)
            {
                if (!Reader.TryReadLine("Enter your email: ", out email) || !ValidationHelper.IsValidEmail(email))
                {
                    Console.WriteLine("Invalid email format. Please try again.");
                    continue;
                }
                break;
            }

            string password;
            if (!Reader.TryReadLine("Enter your password: ", out password) || !ValidationHelper.IsValidPassword(password))
            {
                Console.WriteLine("Password must be at least 6 characters long.");
                return;
            }

            Console.WriteLine($"Attempting to log in with email: {email}");
            var user = userRepository.GetByEmailAndPassword(email, password);
            if (user != null)
            {
                Console.WriteLine("Login successful! Welcome.");
                var mainMenu = new MainMenu();
                mainMenu.Execute();
            }
            else Console.WriteLine("Invalid email or password. Please try again.");

            Console.ReadKey();
        }
    }
}
