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

            string email = Reader.ReadEmail();
            var existingUser = userRepository.GetByEmail(email);
            if (existingUser != null)
            {
                Writer.Error("This email is already registered.");
                return;
            }

            string password = Reader.ReadPassword();
            string confirmPassword;
            while (true)
            {
                confirmPassword = Reader.ReadPassword();
                if (password != confirmPassword)
                {
                    Writer.Error("Passwords do not match. Please try again.");
                    continue;
                }
                break;
            }

            string captcha = Writer.GenerateCaptcha();
            Writer.Write($"Captcha: {captcha}");
            string captchaInput;
            while (true)
            {
                captchaInput = Reader.ReadLine("Please enter the captcha: ");
                if (!ValidationHelper.IsCaptchaValid(captcha, captchaInput))
                {
                    Writer.Error("Captcha incorrect. Please try again.");
                    continue;
                }
                break;
            }

            var newUser = new User(email, password, email.Split('@')[0]);
            var result = userRepository.Add(newUser);
            if (result == ResponseResultType.Success)
                Writer.Write("Registration successful! You can now log in.");
            else Writer.Error("Registration failed. Please try again.");

            Console.ReadKey();
        }
    }
}
