using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;
using DumpDrive.Domain.Factories;
using DumpDrive.Data.Entities.Models;
using DumpDrive.Domain.Enums;

namespace DumpDrive.Presentation.Actions
{
    public class Register : IAction
    {
        public string Name { get; set; } = "Register";

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

            var existingUser = userRepository.GetByEmail(email);
            if (existingUser != null)
            {
                Console.WriteLine("This email is already registered.");
                return;
            }

            string password, confirmPassword;
            while (true)
            {
                if (!Reader.TryReadLine("Enter your password: ", out password))
                {
                    Console.WriteLine("Password cannot be empty.");
                    continue;
                }

                if (!Reader.TryReadLine("Confirm your password: ", out confirmPassword) || password != confirmPassword)
                {
                    Console.WriteLine("Passwords do not match. Please try again.");
                    continue;
                }
                break;
            }

            string captcha = ValidationHelper.GenerateCaptcha();
            Console.WriteLine($"Captcha: {captcha}");
            string captchaInput;
            while (true)
            {
                if (!Reader.TryReadLine("Please enter the captcha: ", out captchaInput) || !ValidationHelper.IsCaptchaValid(captcha, captchaInput))
                {
                    Console.WriteLine("Captcha incorrect. Please try again.");
                    continue;
                }
                break;
            }

            var newUser = new User(email, password, email.Split('@')[0]);

            var result = userRepository.Add(newUser);
            if (result == ResponseResultType.Success)
                Console.WriteLine("Registration successful! You can now log in.");
            else Console.WriteLine("Registration failed. Please try again.");

            Console.ReadKey();
        }
    }
}
