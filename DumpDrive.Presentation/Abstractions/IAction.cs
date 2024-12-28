using DumpDrive.Data.Entities.Models;

namespace DumpDrive.Presentation.Abstractions
{
    public interface IAction
    {
        string Name { get; }
        void Execute();
    }
}
