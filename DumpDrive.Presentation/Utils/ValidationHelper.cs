using System.Text.RegularExpressions;

namespace DumpDrive.Presentation.Utils
{
    public static class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[\w\.-]+@[\w\.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }

        public static string GenerateCaptcha()
        {
            var random = new Random();
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(0, 6).Select(x => validChars[random.Next(validChars.Length)]).ToArray());
        }

        public static bool IsCaptchaValid(string captcha, string input)
        {
            return captcha == input;
        }
    }
}
