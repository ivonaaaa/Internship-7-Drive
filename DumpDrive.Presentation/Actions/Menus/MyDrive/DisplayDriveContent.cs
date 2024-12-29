using DumpDrive.Domain.Enums;
using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Actions.Menus.MyDrive
{
    public class DisplayDriveContent : IAction
    {
        private readonly DriveRepository _driveRepository;
        private readonly int _userId;

        public string Name => "Display Drive Contents";

        public DisplayDriveContent(DriveRepository driveRepository, int userId)
        {
            _driveRepository = driveRepository;
            _userId = userId;
        }

        public void Execute()
        {
            Console.Clear();

            var folders = _driveRepository.GetUserFolders(_userId);
            if (!folders.Any())
            {
                Console.WriteLine("No folders found.");
                return;
            }

            Console.WriteLine("Your Drive Contents:");
            foreach (var folder in folders)
            {
                Console.WriteLine($"[Folder] {folder.Name}");
                var files = _driveRepository.GetFolderFiles(folder.Id);
                foreach (var file in files)
                    Console.WriteLine($"\t[File] {file.Name} (Last changed: {file.LastChanged})");
            }

            Console.WriteLine("\nPress any key for further content management...");
            Console.ReadKey();

            ShowCommands();
        }

        private void ShowCommands()
        {
            Console.WriteLine("Commands:" +
                "\n1. Create Folder" +
                "\n2. Create File" +
                "\n3. Rename Folder" +
                "\n4. Rename File" +
                "\n5. Delete Folder" +
                "\n6. Delete File" +
                "\n7. Exit to Main Menu");

            Console.Write("\nEnter a command: ");
            var command = Console.ReadLine();
            HandleCommand(command);
        }

        private void HandleCommand(string? command)
        {
            switch (command)
            {
                case "1":
                    HandleFolderCreation();
                    break;
                case "2":
                    HandleFileCreation();
                    break;
                case "3":
                    HandleFolderRenaming();
                    break;
                case "4":
                    HandleFileRenaming();
                    break;
                case "5":
                    HandleFolderDeletion();
                    break;
                case "6":
                    HandleFileDeletion();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Execute();
        }

        private void HandleFolderCreation()
        {
            if (Reader.TryReadLine("Enter folder name: ", out var folderName))
            {
                var createFolderResult = _driveRepository.CreateFolder(_userId, folderName);
                PrintResult(createFolderResult, "Folder created successfully.", "Failed to create folder.");
            }
        }

        private void HandleFileCreation()
        {
            if (Reader.TryReadNumber("Enter folder ID to add file: ", out var folderId))
            {
                if (Reader.TryReadLine("Enter file name: ", out var fileName))
                {
                    var createFileResult = _driveRepository.CreateFile(folderId, fileName);
                    PrintResult(createFileResult, "File created successfully.", "Failed to create file.");
                }
            }
        }

        private void HandleFolderRenaming()
        {
            if (Reader.TryReadNumber("Enter folder ID to rename: ", out var folderIdRename))
            {
                if (Reader.TryReadLine("Enter new folder name: ", out var newFolderName))
                {
                    var renameFolderResult = _driveRepository.RenameFolder(folderIdRename, newFolderName);
                    PrintResult(renameFolderResult, "Folder renamed successfully.", "Failed to rename folder.");
                }
            }
        }

        private void HandleFileRenaming()
        {
            if (Reader.TryReadNumber("Enter file ID to rename: ", out var fileIdRename))
            {
                if (Reader.TryReadLine("Enter new file name: ", out var newFileName))
                {
                    var renameFileResult = _driveRepository.RenameFile(fileIdRename, newFileName);
                    PrintResult(renameFileResult, "File renamed successfully.", "Failed to rename file.");
                }
            }
        }

        private void HandleFolderDeletion()
        {
            if (Reader.TryReadNumber("Enter folder ID to delete: ", out var folderIdDelete))
            {
                var deleteFolderResult = _driveRepository.DeleteFolder(folderIdDelete);
                PrintResult(deleteFolderResult, "Folder deleted successfully.", "Failed to delete folder.");
            }
        }

        private void HandleFileDeletion()
        {
            if (Reader.TryReadNumber("Enter file ID to delete: ", out var fileIdDelete))
            {
                var deleteFileResult = _driveRepository.DeleteFile(fileIdDelete);
                PrintResult(deleteFileResult, "File deleted successfully.", "Failed to delete file.");
            }
        }

        private void PrintResult(ResponseResultType result, string successMessage, string failureMessage)
        {
            if (result == ResponseResultType.Success)
                Writer.Write(successMessage);
            else
                Writer.Write(failureMessage);
        }
    }
}
