
namespace DumpDrive.Presentation.Abstractions
{
    public interface IAction
    {
        string Name { get; }
        void Execute();
    }
}
 