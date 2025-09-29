using DumpDrive.Domain.Enums;
using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Actions.Menus.SharedWithMe
{
    public class HandleSharedContent : IAction
    {
        private readonly int _userId;
        private readonly SharedRepository _sharedRepository;
        private readonly JointActions _jointActions;

        public string Name => "Shared With Me";

        public HandleSharedContent(int userId, SharedRepository sharedRepository, JointActions jointActions)
        {
            _userId = userId;
            _sharedRepository = sharedRepository;
            _jointActions = jointActions;
        }

        public void Execute()
        {
            Console.Clear();

            var sharedFolders = _sharedRepository.GetSharedFolders(_userId);
            var sharedFiles = _sharedRepository.GetSharedFiles(_userId);

            if (!sharedFolders.Any() && !sharedFiles.Any())
            {
                Writer.Write("No shared content found.\n\nPress any key to continue...");
                Console.ReadKey();
                return;
            }

            Writer.Write("Shared Folders:");
            foreach (var folder in sharedFolders)
            {
                Writer.Write($"[Folder] {folder.Name}");

                var filesInFolder = _sharedRepository.GetSharedFilesInFolder(folder.Id, _userId);
                foreach (var file in filesInFolder)
                    Writer.Write($"\t[File] {file.Name}");
            }

            var filesNotInFolders = sharedFiles.Where(file => !sharedFolders.Any(f => f.Files.Contains(file))).ToList();
            if (filesNotInFolders.Any())
            {
                Writer.Write("\nShared Files (not in folders):");
                foreach (var file in filesNotInFolders)
                    Writer.Write($"\t[File] {file.Name}");
            }

            Start();
        }
        private void Start()
        {
            var command = Reader.ReadLine("\nEnter a command (or type 'help'): ").Trim().ToLower();
            HandleCommand(command);
        }

        private void HandleCommand(string command)
        {
            switch (command)
            {
                case "help":
                    ShowFolderCommands();
                    break;
                case var cmd when cmd.StartsWith("remove folder"):
                    RemoveFolder(command);
                    break;
                case var cmd when cmd.StartsWith("enter folder"):
                    EnterFolder(command);
                    break;
                case var cmd when cmd.StartsWith("edit file"):
                    _jointActions.HandleFileEditing(command);
                    break;
                case var cmd when cmd.StartsWith("enter file"):
                    _jointActions.EnterFile(command);
                    break;
                case "back":
                    return;
                default:
                    Writer.Error("Invalid command.");
                    break;
            }

            Writer.Write("Press any key to continue...");
            Console.ReadKey();
            Execute();
        }

        private void ShowFolderCommands()
        {
            Console.WriteLine("Folder commands:\n" +
                " > remove folder [name] - Remove a folder from your view\n" +
                " > enter folder [name] - Enter a folder and view its contents\n" +
                " > edit file [name] - Edit the specified file\n" +
                " > enter file [name] - Enter the specified file and see its contents\n" +
                " > back - Go back to the previous menu\n");
        }

        private void ShowFileCommands()
        {
            Writer.Write("File commands:\n" +
                " > edit file [name] - Edits the specified file\n" +
                " > enter file [name] - Displays the contents of the specified file\n" +
                " > back - Exits the folder view\n");
        }

        private void RemoveFolder(string command)
        {
            var folderName = command.Substring("remove folder".Length).Trim();

            if (string.IsNullOrWhiteSpace(folderName))
            {
                Writer.PrintResult(ResponseResultType.Failure, "", "Folder name cannot be empty.");
                return;
            }

            var folder = _sharedRepository.GetSharedFolders(_userId).FirstOrDefault(f => f.Name.Equals(folderName, StringComparison.OrdinalIgnoreCase));

            if (folder == null)
            {
                Writer.PrintResult(ResponseResultType.Failure, "", "Folder not found.");
                return;
            }

            var result = _sharedRepository.RemoveFolderFromView(folder.Id, _userId);

            if (result == ResponseResultType.Success)
                Writer.PrintResult(ResponseResultType.Success, "Folder removed from view.", "");
            else Writer.PrintResult(ResponseResultType.Failure, "", "Failed to remove folder.");
        }

        private void EnterFolder(string command)
        {
            var folderName = command.Substring("enter folder".Length).Trim();

            if (string.IsNullOrWhiteSpace(folderName))
            {
                Writer.PrintResult(ResponseResultType.Failure, "", "Folder name is required.");
                return;
            }

            var folder = _sharedRepository.GetSharedFolders(_userId).FirstOrDefault(f => f.Name.Equals(folderName, StringComparison.OrdinalIgnoreCase));

            if (folder == null)
            {
                Writer.PrintResult(ResponseResultType.Failure, "", "Folder not found.");
                return;
            }

            var files = _sharedRepository.GetFilesInFolder(folder.Id, _userId);

            if (!files.Any())
            {
                Writer.Write("No files found in this folder.");
                return;
            }

            Writer.Write("Files in this folder:");
            foreach (var file in files)
                Writer.Write($"\t[File] {file.Name}");

            HandleFolderContents();
        }

        private void HandleFolderContents()
        {
            while (true)
            {
                var command = Reader.ReadLine("\nEnter a command (or type 'help'): ").Trim().ToLower();

                if (string.IsNullOrEmpty(command))
                {
                    Writer.Error("Command cannot be empty.");
                    continue;
                }

                switch (command)
                {
                    case "help":
                        ShowFileCommands();
                        break;
                    case var cmd when cmd.StartsWith("edit file"):
                        _jointActions.HandleFileEditing(command);
                        break;
                    case var cmd when cmd.StartsWith("enter file"):
                        _jointActions.EnterFile(command);
                        break;
                    case "back":
                        return;
                    default:
                        Writer.Error("Invalid command.");
                        break;
                }

                Writer.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
