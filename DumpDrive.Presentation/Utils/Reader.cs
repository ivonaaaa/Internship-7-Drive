
namespace DumpDrive.Presentation.Utils
{
    public class Reader
    {
        public static bool TryReadNumber(out int number)
        {
            number = 0;
            var isNumber = int.TryParse(Console.ReadLine(), out var inputNumber);
            if (!isNumber)
                return false;

            number = inputNumber;
            return true;
        }

        public static bool TryReadNumber(string message, out int number)
        {
            Console.WriteLine(message);
            return TryReadNumber(out number);
        }

        public static bool TryReadLine(string message, out string line)
        {
            line = string.Empty;

            Console.WriteLine(message);
            var input = Console.ReadLine();
            var isEmpty = string.IsNullOrWhiteSpace(input);

            if (!isEmpty && input is not null)
                line = input;

            return !isEmpty;
        }
        public static bool DoYouWantToContinue()
        {
            Console.WriteLine("If you want to go back to previous page press y");
            var input = Console.ReadLine();
            if (input == "y")
                return false;
            return true;
        }
        public static void ReadInput(out string input)
        {
            input = Console.ReadLine() ?? string.Empty;
        }
        public static string? ReadInput()
        {
            Console.WriteLine("Enter your choosen email");
            var input = Console.ReadLine();
            string[] inputSplitByMonkey = input.Split('@');
            if (inputSplitByMonkey.Length != 2)
            {
                Writer.Error("Your email should contain just one @.");
                return null;
            }
            if (inputSplitByMonkey[0].Length < 1)
            {
                Writer.HowShouldYourEmailLook(1, "before @");
                return null;
            }
            string[] inputSplitByTheDot = input.Split(".");
            if (inputSplitByTheDot.Length != 2)
            {
                Writer.Error("Your email should contain just one dot.");
                return null;
            }
            if (inputSplitByTheDot[0].Length < 3)
            {
                Writer.HowShouldYourEmailLook(3, "between @ and .");
                return null;
            }
            if (inputSplitByTheDot[1].Length < 2)
            {
                Writer.HowShouldYourEmailLook(2, "after .");
                return null;
            }
            return input;
        }

    }
}
