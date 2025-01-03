using DumpDrive.Presentation.Abstractions;
using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Actions.Menus.SharedWithMe;
using DumpDrive.Presentation.Actions.Menus;

namespace DumpDrive.Presentation.Factories
{
    public class SharedWithMe
    {
        private readonly SharedRepository _sharedRepository;
        private readonly JointActions _jointActions;

        public SharedWithMe(int userId, SharedRepository sharedRepository, JointActions jointActions)
        {
            _sharedRepository = sharedRepository;
            _jointActions = jointActions;
        }

        public IAction Create(int userId)
        {
            return new HandleSharedContent( userId, _sharedRepository, _jointActions);
        }
    }
}
