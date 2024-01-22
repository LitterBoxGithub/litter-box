using LitterBox.Api.Data.Repositories.Interfaces;
using LitterBox.Api.Models;
using LitterBox.Api.Models.Requests;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LitterBox.Api.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ILogger<UserRepository> _logger;
        private readonly LitterBoxContext _context;

        public UserRepository(ILogger<UserRepository> logger, LitterBoxContext context)
        {
            _logger = logger;
            _context = context;
        }

        public User GetUserById(Guid userId)
        {
            return _context.Users.Where(user => user.Id == userId).FirstOrDefault();
        }

        public async Task<User> CreateUserAsync(User newUser)
        {
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task<(bool, User)> UpdateUserAsync(User updatedUser)
        {
            var modified = false;
            if(_context.Users.Where(user => user.Id == updatedUser.Id).Any())
            {
                _context.Users.Update(updatedUser);
                modified = true;        // should actually compare old entity to new entity using entity state and fields
            }
            await _context.SaveChangesAsync();
            return (modified, updatedUser);
        }

        public async Task<User> DeleteUserAsync(Guid userId)
        {
            var deletedUser = _context.Users.Where(user => user.Id == userId).First();
            _context.Users.Remove(deletedUser);
            await _context.SaveChangesAsync();
            return deletedUser;
        }
    }
}
