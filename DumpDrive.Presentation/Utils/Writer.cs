using DumpDrive.Data.Entities.Models;

namespace DumpDrive.Presentation.Utils
{
    public class Writer
    {
        public static void Write(User user)
        {
            Console.WriteLine($"{user.Id}: {user.Email}");
        }

        public static void Write(ICollection<User> users)
        {
            foreach (var user in users)
                Write(user);
        }

        public static void Write(string output)
        {
            Console.WriteLine(output);
        }
        public static void Error(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static bool GenerateRandomString()
        {
            Guid myGuid = Guid.NewGuid();
            string fourRandomLatters = myGuid.ToString().Substring(0, 5);
            if (!ContainsLetter(fourRandomLatters) || !ContainsNumber(fourRandomLatters))
                return GenerateRandomString();
            Console.WriteLine("To check you are not a bot repeat this text: " + fourRandomLatters);
            Reader.ReadInput(out string input);
            if (input == fourRandomLatters)
                return true;
            return false;
        }
        public static bool ContainsLetter(string line)
        {
            foreach (char c in line)
                if (char.IsLetter(c))
                    return true;
            return false;
        }
        public static bool ContainsNumber(string line)
        {
            foreach (char c in line)
                if (char.IsDigit(c))
                    return true;
            return false;
        }
        public static void HowShouldYourEmailLook(int number, string where)
        {
            Error($"Your email should contain at least {number} letter {where}.");
        }
    }
}
