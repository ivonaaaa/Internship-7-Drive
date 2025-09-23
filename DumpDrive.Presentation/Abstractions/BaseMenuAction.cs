﻿
namespace DumpDrive.Presentation.Abstractions
{
    public class BaseMenuAction : IMenuAction
    {
        public string Name { get; set; }
        public IList<IAction> Actions { get; set; } = new List<IAction>();
        public int MenuIndex { get; set; }
        public bool CanGoBack { get; set; } = false;

        public void Execute()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- DUMP DRIVE APP ---\n");
                Console.WriteLine($"{Name} menu:\n");

                for (int i = 0; i < Actions.Count; i++)
                    Console.WriteLine($"{i + 1}. {Actions[i].Name}");

                if (CanGoBack)
                    Console.WriteLine($"{Actions.Count + 1}. Go Back");

                Console.Write("\nSelect an option: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (CanGoBack && choice == Actions.Count + 1)
                        return;

                    if (choice >= 1 && choice <= Actions.Count)
                        Actions[choice - 1].Execute();
                    else
                    {
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Press any key to try again.");
                    Console.ReadKey();
                }
            }
        }
    }
}
