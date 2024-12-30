using DumpDrive.Presentation.Abstractions;
using DumpDrive.Domain.Repositories;
using DumpDrive.Presentation.Actions.Menus.SharedWithMe;

namespace DumpDrive.Presentation.Factories
{
    public class SharedWithMe
    {
        private readonly SharedRepository _sharedRepository;

        public SharedWithMe(SharedRepository sharedRepository)
        {
            _sharedRepository = sharedRepository;
        }

        public IAction Create(int userId)
        {
            return new HandleSharedContent(_sharedRepository, userId);
        }
    }
}
