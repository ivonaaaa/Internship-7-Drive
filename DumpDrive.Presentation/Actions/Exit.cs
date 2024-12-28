using DumpDrive.Data.Entities.Models;
using DumpDrive.Presentation.Abstractions;

namespace DumpDrive.Presentation.Actions
{
    public class Exit : IAction
    {
        public User User { get; set; }
        public int MenuIndex { get; set; }
        public string Name { get; set; } = "Exit";

        public Exit()
        {
        }

        public void Execute()
        {
            Console.WriteLine("Exiting application...");
            Environment.Exit(0);
        }
    }
}
