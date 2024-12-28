using DumpDrive.Presentation.Abstractions;

namespace DumpDrive.Presentation.Extensions
{
    public static class ActionExtensions
    {
        public static void SetActionIndexes(this IList<IAction> actions)
        {
            for (int i = 0; i < actions.Count; i++)
            {
                if (actions[i] is IMenuAction menuAction)
                {
                    menuAction.MenuIndex = i + 1;
                }
            }
        }

        public static void PrintActionsAndOpen(this IList<IAction> actions)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");

                for (int i = 0; i < actions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {actions[i].Name}");
                }

                Console.WriteLine("0. Exit");
                Console.Write("\nSelect an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }

                    if (choice >= 1 && choice <= actions.Count)
                    {
                        actions[choice - 1].Execute();
                    }
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
