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

        public static bool IsCaptchaValid(string captcha, string input)
        {
            return captcha == input;
        }
    }
}
