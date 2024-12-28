using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Utils;

namespace DumpDrive.Presentation.Factories
{
    public class MainMenu : IMenuAction
    {
        public string Name { get; set; } = "Main";
        public IList<IAction> Actions { get; set; }
        public int MenuIndex { get; set; }

        public MainMenu()
        {
            Actions = new List<IAction>
            {
                //new mydrive(),
                //new sharedwithme(),
                //new profilesettings(),
                //new logout()
            };
        }

        public void Execute()
        {
            var menuGenerator = new MenuGenerator
            {
                Name = "Main",
                Actions = Actions
            };
            menuGenerator.Execute();
        }
    }
}
