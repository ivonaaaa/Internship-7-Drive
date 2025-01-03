using DumpDrive.Data.Entities;
using DumpDrive.Data.Entities.Models;
using DumpDrive.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace DumpDrive.Domain.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(DumpDriveDbContext dbContext) : base(dbContext)
        {
        }

        public User? GetById(int id) => DbContext.Users.FirstOrDefault(u => u.Id == id);

        public User GetUserByEmail(string email) => DbContext.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());

        public User? GetByEmailAndPassword(string email, string password) => DbContext.Users.FirstOrDefault(u => u.Password == password && u.Email == email);

        public ResponseResultType Add(User user)
        {
            DbContext.Users.Add(user);

            return SaveChanges();
        }

        public ResponseResultType Update(User user, int id)
        {
            var userToUpdate = GetById(id);
            if (userToUpdate is null)
                return ResponseResultType.NotFound;

            userToUpdate.Email = user.Email;
            userToUpdate.Password = user.Password;

            return SaveChanges();
        }
    }
}
