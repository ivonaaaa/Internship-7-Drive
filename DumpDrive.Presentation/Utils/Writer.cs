using DumpDrive.Data.Entities.Models;
using DumpDrive.Domain.Enums;

namespace DumpDrive.Presentation.Utils
{
    public class Writer
    {
        public static void Write(string output)
        {
            Console.WriteLine(output);
        }
        public static void Error(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(1000);
        }

        public static string GenerateCaptcha()
        {
            var random = new Random();
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(0, 6).Select(x => validChars[random.Next(validChars.Length)]).ToArray());
        }

        public static void PrintResult(ResponseResultType result, string successMessage, string failureMessage)
        {
            if (result == ResponseResultType.Success)
                Writer.Write(successMessage);
            else Writer.Error(failureMessage);
        }
    }
}
