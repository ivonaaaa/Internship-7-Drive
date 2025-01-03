﻿using DumpDrive.Data.Entities.Models;
using DumpDrive.Domain.Enums;
using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Actions.Menus.MyDrive
{
    public class HandleDriveContent : IAction
    {
        private readonly UserRepository _userRepository;
        private readonly int _userId;
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;
        private readonly JointActions _jointActions;

        public string Name => "Display Drive Contents";

        public HandleDriveContent(UserRepository userRepository, int userId, DriveRepository driveRepository, SharedRepository sharedRepository, JointActions jointActions)
        {
            _userRepository = userRepository;
            _userId = userId;
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
            _jointActions = jointActions;
        }

        private int currentFolderId;

        public void Execute()
        {
            Console.Clear();

            var folders = _driveRepository.GetUserFolders(_userId);
            var files = _driveRepository.GetFolderFiles(_userId).OrderByDescending(f => f.LastChanged).ToList();

            if (!folders.Any() && !files.Any())
            {
                Writer.Write("No folders found.\n\nPress any key to continue...");
                Console.ReadKey();
                return;
            }

            Writer.Write("Your Drive Contents:");
            foreach (var folder in folders)
                Writer.Write($"[Folder] {folder.Name}");

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
                case var cmd when cmd.StartsWith("create folder"):
                    HandleFolderCreation(command);
                    break;
                case var cmd when cmd.StartsWith("create file"):
                    HandleFileCreation(command);
                    break;
                case var cmd when cmd.StartsWith("enter folder"):
                    HandleFolderNavigation(command);
                    break;
                case var cmd when cmd.StartsWith("edit file"):
                    _jointActions.HandleFileEditing(command);
                    break;
                case var cmd when cmd.StartsWith("delete folder") || cmd.StartsWith("delete file"):
                    HandleDeletion(command);
                    break;
                case var cmd when cmd.StartsWith("rename folder") || cmd.StartsWith("rename file"):
                    HandleRenaming(command);
                    break;
                case var cmd when cmd.StartsWith("share"):
                    HandleShareContent(command);
                    break;
                case var cmd when cmd.StartsWith("unshare"):
                    HandleUnshareContent(command);
                    break;
                case "back":
                    return;
                default:
                    Writer.Error("Invalid command.");
                    break;
            }

            Writer.Write("\nPress any key to continue...");
            Console.ReadKey();
            Execute();
        }

        private void ShowFolderCommands()
        {
            Writer.Write("Folder commands:\n" +
                " > create folder [folder name] - Create a folder at the current location\n" +
                " > enter folder [folder name] - Enter a folder and view its contents\n" +
                " > delete folder [name] - Delete a folder\n" +
                " > rename folder [name] to [new name] - Rename a folder\n" +
                " > share folder [name] with [email] - Share a folder with a user by email\n" +
                " > unshare folder [name] with [email] - Stop sharing a folder with a user by email\n" +
                " > back - Go back to the previous menu\n");
        }

        private void ShowFileCommands()
        {
            Writer.Write("File commands:\n" +
                " > create file [name] - Create a file in this folder\n" +
                " > edit file [name] - Edit a file\n" +
                " > enter file [name] - Displays the contents of the specified file\n" +
                " > delete file [name] - Delete a file\n" +
                " > rename file [name] to [new name] - Rename a file\n" +
                " > share file [name] with [email] - Share a file\n" +
                " > unshare file [name] with [email] - Stop sharing a file\n" +
                " > back - Go back to the previous menu\n");
        }

        private void HandleFolderCreation(string command)
        {
            var folderName = command.Substring("create folder".Length).Trim();
            if (string.IsNullOrWhiteSpace(folderName))
            {
                Writer.Error("Folder name cannot be empty.");
                return;
            }

            var createFolderResult = _driveRepository.CreateFolder(_userId, folderName);
            Writer.PrintResult(createFolderResult, "Folder created successfully.", "Failed to create folder.");
        }

        public void HandleFileCreation(string command)
        {
            var fileName = command.Substring("create file".Length).Trim();
            if (string.IsNullOrWhiteSpace(fileName))
            {
                Writer.Error("File name cannot be empty.");
                return;
            }

            var createFileResult = _driveRepository.CreateFile(currentFolderId, fileName);
            Writer.PrintResult(createFileResult, "File created successfully.", "Failed to create file.");
        }

        private void HandleFolderNavigation(string command)
        {
            var folderName = command.Substring("enter folder".Length).Trim();
            if (string.IsNullOrWhiteSpace(folderName))
            {
                Writer.Error("Folder name cannot be empty.");
                return;
            }

            var folder = _driveRepository.GetFolderByName(_userId, folderName);
            if (folder == null)
            {
                Writer.Error("Folder not found.");
                return;
            }

            currentFolderId = folder.Id;
            Writer.Write($"\nEntered folder: {folder.Name}");
            bool isInFolder = true;

            while (isInFolder)
            {
                var folderFiles = _driveRepository.GetFolderFiles(folder.Id);
                if (folderFiles.Any())
                {
                    Writer.Write("Files in this folder:");
                    var folderFilesList = folderFiles.ToList();
                    for (int i = 0; i < folderFilesList.Count; i++)
                        Writer.Write($"\t[File] {folderFilesList[i].Name}");
                }
                else Writer.Write("\nNo files in this folder.");

                var userCommand = Reader.ReadLine("\nEnter a command (or type 'help'): ").Trim().ToLower();

                if (string.IsNullOrWhiteSpace(userCommand))
                {
                    Writer.Error("You must type in a proper command.");
                    continue;
                }

                switch (userCommand)
                {
                    case "help":
                        ShowFileCommands();
                        break;

                    case string cmd when cmd.StartsWith("create file", StringComparison.OrdinalIgnoreCase):
                        HandleFileCreation(userCommand);
                        break;
                    case string cmd when cmd.StartsWith("edit file", StringComparison.OrdinalIgnoreCase):
                        _jointActions.HandleFileEditing(userCommand);
                        break;
                    case string cmd when cmd.StartsWith("enter file", StringComparison.OrdinalIgnoreCase):
                        _jointActions.EnterFile(userCommand);
                        break;
                    case string cmd when cmd.StartsWith("delete file", StringComparison.OrdinalIgnoreCase):
                        HandleDeletion(userCommand);
                        break;
                    case string cmd when cmd.StartsWith("rename file", StringComparison.OrdinalIgnoreCase):
                        HandleRenaming(userCommand);
                        break;
                    case string cmd when cmd.StartsWith("share file", StringComparison.OrdinalIgnoreCase):
                        HandleShareContent(userCommand);
                        break;
                    case string cmd when cmd.StartsWith("unshare file", StringComparison.OrdinalIgnoreCase):
                        HandleUnshareContent(userCommand);
                        break;
                    case "back":
                        isInFolder = false;
                        break;
                    default:
                        Writer.Error("Invalid command inside a folder.");
                        break;
                }
            }
        }

        private void HandleDeletion(string command)
        {
            var isFolder = command.StartsWith("delete folder");

            var name = isFolder
                ? command.Substring("delete folder".Length).Trim()
                : command.Substring("delete file".Length).Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Writer.Error("Name cannot be empty.");
                return;
            }

            if (isFolder)
            {
                var deleteFolderResult = _driveRepository.DeleteFolder(_userId, name);
                Writer.PrintResult(deleteFolderResult, "Folder deleted successfully.", "Failed to delete folder.");
            }
            else
            {
                var deleteFileResult = _driveRepository.DeleteFile(_userId, name);
                Writer.PrintResult(deleteFileResult, "File deleted successfully.", "Failed to delete file.");
            }
        }

        private void HandleRenaming(string command)
        {
            var parts = command.Split(new[] { "to" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
            {
                Writer.Error("Invalid rename command. Correct format: rename folder/file 'old name' to 'new name'.");
                return;
            }

            var oldNamePart = parts[0].Trim();
            var oldName = oldNamePart.Replace("rename folder", "").Replace("rename file", "").Trim();
            var newName = parts[1].Trim();

            if (string.IsNullOrWhiteSpace(oldName) || string.IsNullOrWhiteSpace(newName))
            {
                Writer.Error("Both old and new names must be provided.");
                return;
            }

            if (command.StartsWith("rename folder"))
            {
                var renameFolderResult = _driveRepository.RenameFolder(_userId, oldName, newName);
                Writer.PrintResult(renameFolderResult, "Folder renamed successfully.", "Failed to rename folder.");
            }
            else if (command.StartsWith("rename file"))
            {
                var renameFileResult = _driveRepository.RenameFile(_userId, oldName, newName);
                Writer.PrintResult(renameFileResult, "File renamed successfully.", "Failed to rename file.");
            }
        }

        private void HandleShareContent(string command)
        {
            var parts = command.Split(new[] { "with" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
            {
                Writer.Error("Invalid share command. Correct format: share folder/file 'name' with 'email'.");
                return;
            }
            var contentPart = parts[0].Trim();
            var contentName = contentPart.Replace("share folder", "").Replace("share file", "").Trim();
            var email = parts[1].Trim();

            var user = _userRepository.GetUserByEmail(email);
            if (user == null)
            {
                Writer.Error("User not found.");
                return;
            }

            if (command.StartsWith("share folder"))
            {
                var folder = _driveRepository.GetFolderByName(_userId, contentName);
                if (folder == null)
                {
                    Writer.Error("Folder not found.");
                    return;
                }
                var result = _sharedRepository.AddFolderShare(folder.Id, user.Id);
                Writer.PrintResult(result, "Folder shared successfully.",
                    result == ResponseResultType.NoChanges ? "Folder is already shared with this user." : "Failed to share folder.");
            }
            else if (command.StartsWith("share file"))
            {
                var file = _driveRepository.GetFileByName(_userId, contentName);
                if (file == null)
                {
                    Writer.Error("File not found.");
                    return;
                }
                var result = _sharedRepository.AddFileShare(file.Id, user.Id);
                Writer.PrintResult(result, "File shared successfully.",
                    result == ResponseResultType.NoChanges ? "File is already shared with this user." : "Failed to share file.");
            }
        }

        private void HandleUnshareContent(string command)
        {
            var parts = command.Split(new[] { "with" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
            {
                Writer.Error("Invalid unshare command. Correct format: unshare folder/file 'name' with 'email'.");
                return;
            }
            var contentPart = parts[0].Trim();
            var contentName = contentPart.Replace("unshare folder", "").Replace("unshare file", "").Trim();
            var email = parts[1].Trim();

            var user = _userRepository.GetUserByEmail(email);
            if (user == null)
            {
                Writer.Error("User not found.");
                return;
            }

            if (command.StartsWith("unshare folder"))
            {
                var folder = _driveRepository.GetFolderByName(_userId, contentName);
                if (folder == null)
                {
                    Writer.Error("Folder not found.");
                    return;
                }
                var result = _sharedRepository.RemoveFolderShare(folder.Id, user.Id);
                Writer.PrintResult(result, "Folder unshared successfully.", "Failed to unshare folder.");
            }
            else if (command.StartsWith("unshare file"))
            {
                var file = _driveRepository.GetFileByName(_userId, contentName);
                if (file == null)
                {
                    Writer.Error("File not found.");
                    return;
                }
                var result = _sharedRepository.RemoveFileShare(file.Id, user.Id);
                Writer.PrintResult(result, "File unshared successfully.", "Failed to unshare file.");
            }
        }
    }
}
