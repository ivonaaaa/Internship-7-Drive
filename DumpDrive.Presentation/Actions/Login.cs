using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;
using DumpDrive.Presentation.Factories;
using DumpDrive.Presentation.Actions.Menus;

namespace DumpDrive.Presentation.Actions
{
    public class Login : IAction
    {
        private readonly UserRepository _userRepository;
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;

        public string Name => "Login";

        public Login(UserRepository userRepository, DriveRepository driveRepository, SharedRepository sharedRepository)
        {
            _userRepository = userRepository;
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
        }

        public void Execute()
        {
            while (true)
            {
                string email = Reader.ReadEmail();
                string password = Reader.ReadPassword();

                Console.WriteLine($"\nAttempting to log in...");

                var user = _userRepository.GetByEmailAndPassword(email, password);
                if (user != null)
                {
                    Console.WriteLine($"Login successful! Welcome, {user.Username}.\n\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    var jointActions = new JointActions(user.Id, _driveRepository, _sharedRepository);
                    var mainMenu = new MainMenu(_userRepository, user.Id, _driveRepository, _sharedRepository, jointActions).CreateMainMenu();
                    mainMenu.Execute();

                    break;
                }
                else
                {
                    Writer.Error("Invalid email or password. You must wait 30 seconds before trying again.");
                    Thread.Sleep(30000);
                }
            }
        }
    }
}
