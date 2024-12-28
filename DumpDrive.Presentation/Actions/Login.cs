using System;
using DumpDrive.Presentation.Abstractions;

namespace DumpDrive.Presentation.Actions
{
    public class Login : IAction
    {
        public string Name { get; set; } = "Login";

        public void Execute()
        {
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            // Add your authentication logic here
            Console.WriteLine($"Attempting to log in with email: {email}");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
