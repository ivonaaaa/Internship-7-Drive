using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Actions.Menus.ProfileSettings
{
    public class ChangePassword : IAction
    {
        private readonly UserRepository _userRepository;
        private readonly int _userId;

        public string Name => "Change Password";

        public ChangePassword(UserRepository userRepository, int userId)
        {
            _userRepository = userRepository;
            _userId = userId;
        }

        public void Execute()
        {
            Console.Clear();
            Writer.Write("Change Password...\n");

            var newPassword = Reader.ReadPassword();
            var confirmPassword = Reader.ReadPassword();
            if (newPassword != confirmPassword)
            {
                Writer.Error("Passwords do not match.");
                return;
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
                user.Password = newPassword;
                _userRepository.Update(user, _userId);
                Writer.Write("Password updated successfully.");
            }
            else Writer.Error("User not found.");

            Console.ReadKey();
        }
    }
}
