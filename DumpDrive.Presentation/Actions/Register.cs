using DumpDrive.Presentation.Extensions;
using DumpDrive.Data.Entities.Models;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;
using DumpDrive.Domain.Repositories;

namespace DumpDrive.Presentation.Actions
{
    public class Register : IAction
    {
        public string Name { get; set; } = "Register";

        public void Execute()
        {
            Console.Write("Enter your username: ");
            var username = Console.ReadLine();
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            // Add your registration logic here
            Console.WriteLine($"Registering user: {username}");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
