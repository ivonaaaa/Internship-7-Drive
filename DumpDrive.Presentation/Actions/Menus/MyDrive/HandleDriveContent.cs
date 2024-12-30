using DumpDrive.Domain.Enums;
using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Actions.Menus.MyDrive
{
    public class HandleDriveContent : IAction
    {
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;
        private readonly UserRepository _userRepository;
        private readonly int _userId;

        public string Name => "Display Drive Contents";

        public HandleDriveContent(DriveRepository driveRepository, SharedRepository sharedRepository, UserRepository userRepository, int userId)
        {
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
            _userRepository = userRepository;
            _userId = userId;
        }

        public void Execute()
        {
            Console.Clear();

            var folders = _driveRepository.GetUserFolders(_userId);
            if (!folders.Any())
            {
                Writer.Write("No folders found.");
                return;
            }

            Writer.Write("Your Drive Contents:");
            foreach (var folder in folders)
            {
                Writer.Write($"[Folder] {folder.Name}");
                var files = _driveRepository.GetFolderFiles(folder.Id);
                foreach (var file in files)
                {
                    Writer.Write($"\t[File] {file.Name} (Last changed: {file.LastChanged})");
                }
            }
            ShowCommands();
        }

        private void ShowCommands()
        {
            Writer.Write("Commands:" +
                "\n1. Create Folder" +
                "\n2. Create File" +
                "\n3. Rename Folder" +
                "\n4. Rename File" +
                "\n5. Delete Folder" +
                "\n6. Delete File" +
                "\n7. Share Folder/File" +
                "\n8. Unshare Folder/File" +
                "\n9. Exit to Main Menu");

            var command = Reader.ReadNumber("\nEnter a command: ");
            HandleCommand(command);
        }

        private void HandleCommand(int command)
        {
            switch (command)
            {
                case 1:
                    HandleFolderCreation();
                    break;
                case 2:
                    HandleFileCreation();
                    break;
                case 3:
                    HandleFolderRenaming();
                    break;
                case 4:
                    HandleFileRenaming();
                    break;
                case 5:
                    HandleFolderDeletion();
                    break;
                case 6:
                    HandleFileDeletion();
                    break;
                case 7:
                    HandleSharing();
                    break;
                case 8:
                    HandleUnsharing();
                    break;
                case 9:
                    return;
                default:
                    Writer.Error("Invalid command.");
                    break;
            }

            Writer.Write("Press any key to continue...");
            Console.ReadKey();
            Execute();
        }

        private void HandleFolderCreation()
        {
            var folderName = Reader.ReadLine("Enter folder name: ");
            var createFolderResult = _driveRepository.CreateFolder(_userId, folderName);
            PrintResult(createFolderResult, "Folder created successfully.", "Failed to create folder.");
        }

        private void HandleFileCreation()
        {
            var folderId = Reader.ReadNumber("Enter folder ID to add file: ");
            var fileName = Reader.ReadLine("Enter file name: ");
            var createFileResult = _driveRepository.CreateFile(folderId, fileName);
            PrintResult(createFileResult, "File created successfully.", "Failed to create file.");
        }

        private void HandleFolderRenaming()
        {
            var folderIdRename = Reader.ReadNumber("Enter folder ID to rename: ");
            var newFolderName = Reader.ReadLine("Enter new folder name: ");
            var renameFolderResult = _driveRepository.RenameFolder(folderIdRename, newFolderName);
            PrintResult(renameFolderResult, "Folder renamed successfully.", "Failed to rename folder.");
        }

        private void HandleFileRenaming()
        {
            var fileIdRename = Reader.ReadNumber("Enter file ID to rename: ");
            var newFileName = Reader.ReadLine("Enter new file name: ");
            var renameFileResult = _driveRepository.RenameFile(fileIdRename, newFileName);
            PrintResult(renameFileResult, "File renamed successfully.", "Failed to rename file.");
        }

        private void HandleFolderDeletion()
        {
            var folderIdDelete = Reader.ReadNumber("Enter folder ID to delete: ");
            var deleteFolderResult = _driveRepository.DeleteFolder(folderIdDelete);
            PrintResult(deleteFolderResult, "Folder deleted successfully.", "Failed to delete folder.");
        }

        private void HandleFileDeletion()
        {
            var fileIdDelete = Reader.ReadNumber("Enter file ID to delete: ");
            var deleteFileResult = _driveRepository.DeleteFile(fileIdDelete);
            PrintResult(deleteFileResult, "File deleted successfully.", "Failed to delete file.");
        }

        private void HandleSharing()
        {
            Writer.Write("Share Options:" +
                "\n1. Share Folder" +
                "\n2. Share File");

            var shareChoice = Reader.ReadNumber("\nEnter your choice: ");
            if (shareChoice == 1)
            {
                var folderId = Reader.ReadNumber("Enter folder ID to share: ");
                ShareContent(folderId, isFolder: true);
            }
            else if (shareChoice == 2)
            {
                var fileId = Reader.ReadNumber("Enter file ID to share: ");
                ShareContent(fileId, isFolder: false);
            }
            else
            {
                Writer.Error("Invalid choice.");
            }
        }

        private void ShareContent(int contentId, bool isFolder)
        {
            var users = _userRepository.GetAllUsersExcept(_userId).ToList();
            if (!users.Any())
            {
                Writer.Write("No users available to share with.");
                return;
            }

            Writer.Write("Select a user to share with:");
            for (int i = 0; i < users.Count; i++)
            {
                Writer.Write($"{i + 1}. {users[i].Email}");
            }

            var selectedIndex = Reader.ReadNumber("Enter the user number: ") - 1;
            if (selectedIndex < 0 || selectedIndex >= users.Count)
            {
                Writer.Error("Invalid selection.");
                return;
            }

            var selectedUser = users[selectedIndex];
            ResponseResultType result;

            if (isFolder)
            {
                result = _sharedRepository.ShareFolder(contentId, selectedUser.Id);
            }
            else
            {
                result = _sharedRepository.ShareFile(contentId, selectedUser.Id);
            }

            PrintResult(result, "Content shared successfully.", "Failed to share content.");
        }

        private void HandleUnsharing()
        {
            Writer.Write("Unshare Options:" +
                "\n1. Unshare Folder" +
                "\n2. Unshare File");

            var unshareChoice = Reader.ReadNumber("\nEnter your choice: ");
            if (unshareChoice == 1)
            {
                var folderId = Reader.ReadNumber("Enter folder ID to unshare: ");
                UnshareContent(folderId, isFolder: true);
            }
            else if (unshareChoice == 2)
            {
                var fileId = Reader.ReadNumber("Enter file ID to unshare: ");
                UnshareContent(fileId, isFolder: false);
            }
            else
            {
                Writer.Error("Invalid choice.");
            }
        }

        private void UnshareContent(int contentId, bool isFolder)
        {
            var result = ResponseResultType.NotFound;

            if (isFolder)
            {
                result = _sharedRepository.UnshareFolder(contentId);
            }
            else
            {
                result = _sharedRepository.UnshareFile(contentId);
            }

            PrintResult(result, "Content unshared successfully.", "Failed to unshare content.");
        }


        private void PrintResult(ResponseResultType result, string successMessage, string failureMessage)
        {
            if (result == ResponseResultType.Success)
                Writer.Write(successMessage);
            else
                Writer.Error(failureMessage);
        }
    }
}
