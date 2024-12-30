using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Actions.Menus.ProfileSettings
{
    public class ChangeEmail : IAction
    {
        private readonly UserRepository _userRepository;
        private readonly int _userId;

        public string Name => "Change Email";

        public ChangeEmail(UserRepository userRepository, int userId)
        {
            _userRepository = userRepository;
            _userId = userId;
        }

        public void Execute()
        {
            Console.Clear();
            Writer.Write("Change Email...\n");

            string newEmail;
            while (true)
            {
                newEmail = Reader.ReadEmail();
                if (_userRepository.GetByEmail(newEmail) != null)
                    Writer.Error("Email already in use. Please enter a different one.");
                else break;
            }

            var captcha = Writer.GenerateCaptcha();
            Writer.Write($"Captcha: {captcha}");
            var userInputCaptcha = Reader.ReadLine("Enter captcha: ");

            if (!ValidationHelper.IsCaptchaValid(captcha, userInputCaptcha))
            {
                Writer.Error("Captcha validation failed.");
                return;
            }

            var user = _userRepository.GetById(_userId);
            if (user != null)
            {
                user.Email = newEmail;
                _userRepository.Update(user, _userId);
                Writer.Write("Email updated successfully.");
            }
            else Writer.Error("User not found.");

            Console.ReadKey();
        }
    }
}
