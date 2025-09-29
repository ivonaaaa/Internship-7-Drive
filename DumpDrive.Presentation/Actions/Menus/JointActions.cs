using DumpDrive.Data.Entities;
using DumpDrive.Domain.Enums;
using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Actions.Menus
{
    public class JointActions
    {
        private readonly int _userId;
        private readonly DriveRepository _driveRepository;
        private readonly SharedRepository _sharedRepository;

        public JointActions(int userId, DriveRepository driveRepository, SharedRepository sharedRepository)
        {
            _userId = userId;
            _driveRepository = driveRepository;
            _sharedRepository = sharedRepository;
        }

        public void HandleFileEditing(string command)
        {
            var fileName = command.Substring("edit file".Length).Trim();
            if (string.IsNullOrWhiteSpace(fileName))
            {
                Writer.Error("File name cannot be empty.");
                return;
            }

            var file = _driveRepository.GetFileByName(_userId, fileName);
            if (file == null)
            {
                Writer.Error("File not found.");
                return;
            }

            Writer.Write($"Editing file: {file.Name}");
            List<string> fileContent = file.Content
                .Split('\n')
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .ToList();

            bool isEditing = true;
            int currentLineIndex = fileContent.Count;

            while (isEditing)
            {
                Writer.Write("\nFile Content:");
                for (int i = 0; i < fileContent.Count; i++)
                    Writer.Write($"{i + 1}: {fileContent[i]}");

                Writer.Write("\nType in a new line, or press Backspace to delete one (':help' for commands):");
                var input = Reader.ReadInputWithBackspace();

                if (input.isBackspace)
                {
                    if (currentLineIndex > 0)
                    {
                        currentLineIndex--;
                        Writer.Write($"Deleted line {currentLineIndex + 1}: {fileContent[currentLineIndex]}");
                        fileContent.RemoveAt(currentLineIndex);
                    }
                    else Writer.Error("No lines to delete.");
                }
                else if (string.IsNullOrWhiteSpace(input.line))
                {
                    Writer.Error("Invalid input.");
                    continue;
                }
                else if (input.line.StartsWith(":"))
                    HandleFileEditingCommand(input.line, ref isEditing, fileContent, file);
                else
                {
                    if (currentLineIndex < fileContent.Count)
                        fileContent[currentLineIndex] = input.line;
                    else fileContent.Add(input.line);
                    Writer.Write("Line added/updated.");
                    currentLineIndex++;
                }
            }
        }

        private void HandleFileEditingCommand(string input, ref bool isEditing, List<string> fileContent, DumpFile file)
        {
            switch (input.ToLower())
            {
                case ":help":
                    Writer.Write("Editing commands:\n" +
                        " > :help - Show all commands\n" +
                        " > :save - Save changes and exit\n" +
                        " > :exit - Exit without saving\n");
                    break;
                case ":save":
                    var contentToSave = string.Join("\n", fileContent);
                    var saveResult = _driveRepository.UpdateFileContent(file.Id, contentToSave);
                    if (saveResult == ResponseResultType.Success)
                        Writer.Write("File saved successfully.");
                    else Writer.Error("Failed to save the file.");
                    isEditing = false;
                    break;
                case ":exit":
                    Writer.Write("Exiting without saving...");
                    isEditing = false;
                    break;
                default:
                    fileContent.Add(input);
                    Writer.Write("Content added to the file.");
                    break;
            }
        }

        public void EnterFile(string command)
        {
            var parts = command.Substring("enter file".Length).Trim();
            if (string.IsNullOrWhiteSpace(parts))
            {
                Writer.PrintResult(ResponseResultType.Failure, "", "File name is required.");
                return;
            }

            var fileName = parts;

            var file = _sharedRepository.GetAccessibleFiles(_userId)
                        .FirstOrDefault(f => f.Name.Equals(fileName, StringComparison.OrdinalIgnoreCase));

            if (file == null)
            {
                Writer.PrintResult(ResponseResultType.Failure, "", "File not found or access denied.");
                return;
            }

            Writer.Write($"Opening file: {file.Name}");
            Writer.Write(file.Content);

            while (true)
            {
                var fileCommand = Reader.ReadLine("\nEnter a command (or type 'help'): ").Trim().ToLower();

                if (fileCommand == "help")
                {
                    Writer.Write("open comments - Get insight into this file's comments\n" +
                        "back - Exits the file view");
                }
                if (fileCommand == "back")
                    break;
                else if (fileCommand == "open comments")
                    DisplayComments(file.Id);
            }
        }

        private void DisplayComments(int fileId)
        {
            var comments = _sharedRepository.GetCommentsByFileId(fileId).ToList(); ;

            if (!comments.Any())
                Writer.Write("No comments available for this file.");

            while (true)
            {
                Writer.Write("\nComments:");
                foreach (var comment in comments)
                {
                    Writer.Write($"{comment.Id}-{comment.User.Email}-{comment.CreatedAt}");
                    Writer.Write($"   Content: {comment.Content}");
                    Writer.Write(new string('-', 50));
                }

                Writer.Write("\nEnter command ('add comment', 'edit comment', 'delete comment', 'back'): ");
                var commandInput = Reader.ReadLine("> ").Trim().ToLower();

                switch (commandInput)
                {
                    case "add comment":
                        AddComment(fileId);
                        break;
                    case "edit comment":
                        EditComment(fileId, comments);
                        break;
                    case "delete comment":
                        DeleteComment(fileId, comments);
                        break;
                    case "back":
                        Writer.Write("Returning to the file...");
                        return;
                    default:
                        Writer.PrintResult(ResponseResultType.Failure, "", "Invalid command.");
                        break;
                }
                comments = _sharedRepository.GetCommentsByFileId(fileId).ToList();
            }
        }

        private void AddComment(int fileId)
        {
            var content = Reader.ReadLine("Enter your comment: ");
            var addResult = _sharedRepository.AddComment(fileId, _userId, content);

            Writer.PrintResult(addResult, "Comment added successfully.", "Failed to add comment.");
        }

        private void EditComment(int fileId, List<Comment> comments)
        {
            Writer.Write("Enter the ID of the comment to edit:");
            var commentIdToEdit = Reader.ReadNumber("Comment ID: ");

            var commentToEdit = comments.FirstOrDefault(c => c.Id == commentIdToEdit);
            if (commentToEdit == null)
            {
                Writer.PrintResult(ResponseResultType.Failure, "", "Invalid comment ID.");
                return;
            }

            Writer.Write("Enter new content for the comment:");
            var newContent = Reader.ReadLine("New Content: ");
            var editResult = _sharedRepository.UpdateComment(commentIdToEdit, newContent, _userId);

            Writer.PrintResult(editResult, "Comment updated successfully.", "You cannot edit another users comment.");
        }

        private void DeleteComment(int fileId, List<Comment> comments)
        {
            Writer.Write("Enter the ID of the comment to delete:");
            var commentIdToDelete = Reader.ReadNumber("Comment ID: ");

            var commentToDelete = comments.FirstOrDefault(c => c.Id == commentIdToDelete);
            if (commentToDelete == null)
            {
                Writer.PrintResult(ResponseResultType.Failure, "", "Invalid comment ID.");
                return;
            }

            var deleteResult = _sharedRepository.DeleteComment(commentIdToDelete, _userId);

            Writer.PrintResult(deleteResult, "Comment deleted successfully.", "You cannot delete another users comment.");
        }
    }
}
