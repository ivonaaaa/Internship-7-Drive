
namespace DumpDrive.Presentation.Utils
{
    public class Reader
    {
        public static int ReadNumber(string message)
        {
            int number;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                    break;

                Writer.Error("Invalid number. Please try again.");
            }
            return number;
        }

        public static string ReadLine(string message)
        {
            string line;
            while (true)
            {
                Console.Write(message);
                line = Console.ReadLine() ?? string.Empty;

                if (!string.IsNullOrWhiteSpace(line))
                    break;

                Writer.Error("Input cannot be empty. Please try again.");
            }
            return line;
        }

        public static string ReadEmail()
        {
            string email;
            while (true)
            {
                Console.Write("Enter your email: ");
                email = Console.ReadLine() ?? string.Empty;

                if (ValidationHelper.IsValidEmail(email))
                    break;

                Writer.Error("Invalid email format. Please try again.");
            }
            return email;
        }

        public static string ReadPassword()
        {
            string password;
            while (true)
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine() ?? string.Empty;

                if (!string.IsNullOrWhiteSpace(password))
                    break;

                Writer.Error("Password cannot be empty. Please try again.");
            }
            return password;
        }
    }
}
